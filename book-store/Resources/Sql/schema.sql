--
-- PostgreSQL database dump
--

-- Dumped from database version 16.2
-- Dumped by pg_dump version 16.2

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: check_unique_isbn(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.check_unique_isbn() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    IF EXISTS (
        SELECT 1 FROM book
        WHERE isbn = NEW.isbn AND id <> NEW.id
    ) THEN
        RAISE EXCEPTION 'ISBN must be unique. Duplicate found: %', NEW.isbn;
    END IF;

    RETURN NEW;
END;
$$;


ALTER FUNCTION public.check_unique_isbn() OWNER TO postgres;

--
-- Name: get_author_full_name(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.get_author_full_name(p_author_id integer) RETURNS text
    LANGUAGE plpgsql
    AS $$
DECLARE
    fname TEXT;
    mname TEXT;
    lname TEXT;
BEGIN
    SELECT first_name, mid_name, last_name
    INTO fname, mname, lname
    FROM author
    WHERE id = p_author_id;

    RETURN TRIM(CONCAT_WS(' ', fname, mname, lname));
END;
$$;


ALTER FUNCTION public.get_author_full_name(p_author_id integer) OWNER TO postgres;

--
-- Name: get_cart_total(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.get_cart_total(p_user_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN (
        SELECT COALESCE(SUM(b.price * c.quantity), 0)
        FROM cart_item c
                 JOIN book b ON b.id = c.book_id
        WHERE c.user_id = p_user_id
    );
END;
$$;


ALTER FUNCTION public.get_cart_total(p_user_id integer) OWNER TO postgres;

--
-- Name: get_total_book_quantity(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.get_total_book_quantity(p_book_id integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN (
        SELECT COALESCE(SUM(quantity), 0)
        FROM book_warehouse
        WHERE book_id = p_book_id
    );
END;
$$;


ALTER FUNCTION public.get_total_book_quantity(p_book_id integer) OWNER TO postgres;

--
-- Name: has_user_purchased_book(integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.has_user_purchased_book(p_user_id integer, p_book_id integer) RETURNS boolean
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN EXISTS (
        SELECT 1
        FROM order_item oi
                 JOIN orders o ON oi.order_id = o.id
        WHERE o.user_id = p_user_id
          AND oi.book_id = p_book_id
          AND o.order_status_id = 4
    );
END;
$$;


ALTER FUNCTION public.has_user_purchased_book(p_user_id integer, p_book_id integer) OWNER TO postgres;

--
-- Name: is_book_in_favorites(integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.is_book_in_favorites(p_user_id integer, p_book_id integer) RETURNS boolean
    LANGUAGE plpgsql
    AS $$
BEGIN
    RETURN EXISTS (
        SELECT 1 FROM favorites
        WHERE user_id = p_user_id AND book_id = p_book_id
    );
END;
$$;


ALTER FUNCTION public.is_book_in_favorites(p_user_id integer, p_book_id integer) OWNER TO postgres;

--
-- Name: prevent_user_change(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.prevent_user_change() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
    if OLD.user_id <> NEW.user_id then
        raise exception 'Changing user_id is not allowed!';
    end if;
    return NEW;
end;
$$;


ALTER FUNCTION public.prevent_user_change() OWNER TO postgres;

--
-- Name: set_order_created_at(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.set_order_created_at() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    IF NEW.created_at IS NULL THEN
        NEW.created_at := CURRENT_TIMESTAMP;
    END IF;
    RETURN NEW;
END;
$$;


ALTER FUNCTION public.set_order_created_at() OWNER TO postgres;

--
-- Name: set_paid_in_on_payment(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.set_paid_in_on_payment() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
    if NEW.payment_status_id = 2 and OLD.payment_status_id <> 2 then
        NEW.paid_in := now();
    end if;
    return NEW;
end;
$$;


ALTER FUNCTION public.set_paid_in_on_payment() OWNER TO postgres;

--
-- Name: set_review_timestamps(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION public.set_review_timestamps() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
begin
    if TG_OP = 'INSERT' then
        NEW.created_at := now();
    end if;

    NEW.updated_at := now();
    return NEW;
end;
$$;


ALTER FUNCTION public.set_review_timestamps() OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: author; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.author (
    id integer NOT NULL,
    last_name character varying(127) NOT NULL,
    mid_name character varying(127),
    nationality character varying(127),
    first_name character varying(127) NOT NULL,
    birth_date date,
    death_date date
);


ALTER TABLE public.author OWNER TO postgres;

--
-- Name: author_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.author ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.author_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: book; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.book (
    id integer NOT NULL,
    price integer NOT NULL,
    image_path text,
    series character varying(32),
    year_of_publishing integer NOT NULL,
    isbn character varying(17) NOT NULL,
    number_of_pages integer NOT NULL,
    circulation bigint NOT NULL,
    weight integer,
    age_restrictions integer NOT NULL,
    title text NOT NULL,
    category_id integer NOT NULL,
    description text,
    publisher_id integer,
    author_id integer,
    cover_type_id integer,
    language_id integer,
    height numeric(5,2) DEFAULT 10 NOT NULL,
    width numeric(5,2) DEFAULT 10 NOT NULL,
    length numeric(5,2) DEFAULT 10 NOT NULL,
    CONSTRAINT book_price_check CHECK ((price >= 0))
);


ALTER TABLE public.book OWNER TO postgres;

--
-- Name: book_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.book ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.book_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: book_review; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.book_review (
    id integer NOT NULL,
    user_id integer,
    book_id integer,
    content text NOT NULL,
    rating smallint NOT NULL,
    created_at timestamp without time zone,
    updated_at timestamp without time zone,
    CONSTRAINT book_review_rating_check CHECK (((rating >= 1) AND (rating <= 5)))
);


ALTER TABLE public.book_review OWNER TO postgres;

--
-- Name: book_review_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.book_review ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.book_review_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: book_warehouse; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.book_warehouse (
    book_id integer NOT NULL,
    warehouse_id integer NOT NULL,
    quantity integer DEFAULT 1 NOT NULL
);


ALTER TABLE public.book_warehouse OWNER TO postgres;

--
-- Name: cart_item; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cart_item (
    user_id integer NOT NULL,
    book_id integer NOT NULL,
    quantity integer DEFAULT 1
);


ALTER TABLE public.cart_item OWNER TO postgres;

--
-- Name: category; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.category (
    id integer NOT NULL,
    name character varying(32)
);


ALTER TABLE public.category OWNER TO postgres;

--
-- Name: category_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.category ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.category_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: cover_type; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.cover_type (
    id integer NOT NULL,
    type text NOT NULL
);


ALTER TABLE public.cover_type OWNER TO postgres;

--
-- Name: cover_type_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.cover_type ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.cover_type_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: favorites; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.favorites (
    book_id integer NOT NULL,
    user_id integer NOT NULL
);


ALTER TABLE public.favorites OWNER TO postgres;

--
-- Name: language; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.language (
    id integer NOT NULL,
    name character varying(32) NOT NULL
);


ALTER TABLE public.language OWNER TO postgres;

--
-- Name: language_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.language ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.language_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: order_item; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.order_item (
    order_id integer NOT NULL,
    book_id integer NOT NULL,
    quantity integer DEFAULT 1,
    warehouse_id integer NOT NULL
);


ALTER TABLE public.order_item OWNER TO postgres;

--
-- Name: order_status; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.order_status (
    id integer NOT NULL,
    name character varying(16) NOT NULL
);


ALTER TABLE public.order_status OWNER TO postgres;

--
-- Name: order_status_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.order_status ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.order_status_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: orders; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.orders (
    id integer NOT NULL,
    user_id integer NOT NULL,
    payment_method character varying(127) NOT NULL,
    payment_status_id integer NOT NULL,
    order_status_id integer NOT NULL,
    cost integer NOT NULL,
    paid_in timestamp without time zone DEFAULT now(),
    created_at timestamp without time zone,
    CONSTRAINT orders_cost_check CHECK ((cost > 0))
);


ALTER TABLE public.orders OWNER TO postgres;

--
-- Name: orders_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.orders ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.orders_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: payment_detail; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.payment_detail (
    order_id integer NOT NULL,
    card_number character varying(127) NOT NULL,
    expiration_date character varying(127) NOT NULL,
    code character varying(127) NOT NULL
);


ALTER TABLE public.payment_detail OWNER TO postgres;

--
-- Name: payment_status; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.payment_status (
    id integer NOT NULL,
    name character varying(16) NOT NULL
);


ALTER TABLE public.payment_status OWNER TO postgres;

--
-- Name: payment_status_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.payment_status ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.payment_status_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: publisher; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.publisher (
    id integer NOT NULL,
    name character varying(127) NOT NULL
);


ALTER TABLE public.publisher OWNER TO postgres;

--
-- Name: publisher_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.publisher ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.publisher_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.users (
    id integer NOT NULL,
    username character varying(128) NOT NULL,
    password character varying(256) NOT NULL,
    role integer DEFAULT 0 NOT NULL,
    email character varying(320),
    address text,
    image_path text
);


ALTER TABLE public.users OWNER TO postgres;

--
-- Name: users_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.users ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.users_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: warehouse; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.warehouse (
    id integer NOT NULL,
    name character varying(127) NOT NULL,
    address character varying(256) NOT NULL
);


ALTER TABLE public.warehouse OWNER TO postgres;

--
-- Name: warehouse_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

ALTER TABLE public.warehouse ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.warehouse_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);


--
-- Name: author author_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.author
    ADD CONSTRAINT author_pkey PRIMARY KEY (id);


--
-- Name: book book_isbn_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT book_isbn_key UNIQUE (isbn);


--
-- Name: book book_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT book_pkey PRIMARY KEY (id);


--
-- Name: book_review book_review_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book_review
    ADD CONSTRAINT book_review_pkey PRIMARY KEY (id);


--
-- Name: book_review book_review_user_id_book_id_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book_review
    ADD CONSTRAINT book_review_user_id_book_id_key UNIQUE (user_id, book_id);


--
-- Name: book_warehouse book_warehouse_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book_warehouse
    ADD CONSTRAINT book_warehouse_pkey PRIMARY KEY (book_id, warehouse_id);


--
-- Name: cart_item cart_item_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cart_item
    ADD CONSTRAINT cart_item_pkey PRIMARY KEY (user_id, book_id);


--
-- Name: category category_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.category
    ADD CONSTRAINT category_pkey PRIMARY KEY (id);


--
-- Name: cover_type cover_type_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cover_type
    ADD CONSTRAINT cover_type_pkey PRIMARY KEY (id);


--
-- Name: favorites favorites_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.favorites
    ADD CONSTRAINT favorites_pkey PRIMARY KEY (book_id, user_id);


--
-- Name: language language_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.language
    ADD CONSTRAINT language_pkey PRIMARY KEY (id);


--
-- Name: order_item order_item_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_item
    ADD CONSTRAINT order_item_pkey PRIMARY KEY (order_id, book_id, warehouse_id);


--
-- Name: order_status order_status_name_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_status
    ADD CONSTRAINT order_status_name_key UNIQUE (name);


--
-- Name: order_status order_status_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_status
    ADD CONSTRAINT order_status_pkey PRIMARY KEY (id);


--
-- Name: orders orders_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_pkey PRIMARY KEY (id);


--
-- Name: payment_detail payment_detail_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.payment_detail
    ADD CONSTRAINT payment_detail_pkey PRIMARY KEY (order_id);


--
-- Name: payment_status payment_status_name_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.payment_status
    ADD CONSTRAINT payment_status_name_key UNIQUE (name);


--
-- Name: payment_status payment_status_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.payment_status
    ADD CONSTRAINT payment_status_pkey PRIMARY KEY (id);


--
-- Name: publisher publisher_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.publisher
    ADD CONSTRAINT publisher_pkey PRIMARY KEY (id);


--
-- Name: book title_author_id_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT title_author_id_key UNIQUE (title, author_id);


--
-- Name: users users_email_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_email_key UNIQUE (email);


--
-- Name: users users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);


--
-- Name: users users_username_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.users
    ADD CONSTRAINT users_username_key UNIQUE (username);


--
-- Name: warehouse warehouse_name_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.warehouse
    ADD CONSTRAINT warehouse_name_key UNIQUE (name);


--
-- Name: warehouse warehouse_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.warehouse
    ADD CONSTRAINT warehouse_pkey PRIMARY KEY (id);


--
-- Name: book trg_check_unique_isbn; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER trg_check_unique_isbn BEFORE INSERT OR UPDATE ON public.book FOR EACH ROW EXECUTE FUNCTION public.check_unique_isbn();


--
-- Name: orders trg_prevent_user_change; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER trg_prevent_user_change BEFORE UPDATE ON public.orders FOR EACH ROW EXECUTE FUNCTION public.prevent_user_change();


--
-- Name: orders trg_set_created_at_on_orders; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER trg_set_created_at_on_orders BEFORE INSERT ON public.orders FOR EACH ROW EXECUTE FUNCTION public.set_order_created_at();


--
-- Name: orders trg_set_paid_in; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER trg_set_paid_in BEFORE UPDATE ON public.orders FOR EACH ROW WHEN (((new.payment_status_id = 2) AND (old.payment_status_id IS DISTINCT FROM 2))) EXECUTE FUNCTION public.set_paid_in_on_payment();


--
-- Name: book_review trg_set_review_timestamps; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER trg_set_review_timestamps BEFORE INSERT OR UPDATE ON public.book_review FOR EACH ROW EXECUTE FUNCTION public.set_review_timestamps();


--
-- Name: book book_category_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT book_category_id_fkey FOREIGN KEY (category_id) REFERENCES public.category(id);


--
-- Name: book book_cover_type_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT book_cover_type_id_fkey FOREIGN KEY (cover_type_id) REFERENCES public.cover_type(id);


--
-- Name: book book_language_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT book_language_id_fkey FOREIGN KEY (language_id) REFERENCES public.language(id);


--
-- Name: book_review book_review_book_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book_review
    ADD CONSTRAINT book_review_book_id_fkey FOREIGN KEY (book_id) REFERENCES public.book(id);


--
-- Name: book_review book_review_user_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book_review
    ADD CONSTRAINT book_review_user_id_fkey FOREIGN KEY (user_id) REFERENCES public.users(id);


--
-- Name: book_warehouse book_warehouse_book_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book_warehouse
    ADD CONSTRAINT book_warehouse_book_id_fkey FOREIGN KEY (book_id) REFERENCES public.book(id);


--
-- Name: book_warehouse book_warehouse_warehouse_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book_warehouse
    ADD CONSTRAINT book_warehouse_warehouse_id_fkey FOREIGN KEY (warehouse_id) REFERENCES public.warehouse(id);


--
-- Name: cart_item cart_item_book_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cart_item
    ADD CONSTRAINT cart_item_book_id_fkey FOREIGN KEY (book_id) REFERENCES public.book(id) ON DELETE CASCADE;


--
-- Name: cart_item cart_item_user_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.cart_item
    ADD CONSTRAINT cart_item_user_id_fkey FOREIGN KEY (user_id) REFERENCES public.users(id) ON DELETE CASCADE;


--
-- Name: favorites favorites_book_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.favorites
    ADD CONSTRAINT favorites_book_id_fkey FOREIGN KEY (book_id) REFERENCES public.book(id) ON DELETE CASCADE;


--
-- Name: favorites favorites_user_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.favorites
    ADD CONSTRAINT favorites_user_id_fkey FOREIGN KEY (user_id) REFERENCES public.users(id) ON DELETE CASCADE;


--
-- Name: book fk_author_id_author; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT fk_author_id_author FOREIGN KEY (author_id) REFERENCES public.author(id) ON DELETE CASCADE;


--
-- Name: book fk_publisher_id_publisher; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.book
    ADD CONSTRAINT fk_publisher_id_publisher FOREIGN KEY (publisher_id) REFERENCES public.publisher(id) ON DELETE CASCADE;


--
-- Name: order_item order_item_book_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_item
    ADD CONSTRAINT order_item_book_id_fkey FOREIGN KEY (book_id) REFERENCES public.book(id) ON DELETE CASCADE;


--
-- Name: order_item order_item_order_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_item
    ADD CONSTRAINT order_item_order_id_fkey FOREIGN KEY (order_id) REFERENCES public.orders(id) ON DELETE CASCADE;


--
-- Name: order_item order_item_warehouse_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.order_item
    ADD CONSTRAINT order_item_warehouse_id_fkey FOREIGN KEY (warehouse_id) REFERENCES public.warehouse(id);


--
-- Name: orders orders_order_status_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_order_status_id_fkey FOREIGN KEY (order_status_id) REFERENCES public.order_status(id);


--
-- Name: orders orders_payment_status_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_payment_status_id_fkey FOREIGN KEY (payment_status_id) REFERENCES public.payment_status(id);


--
-- Name: orders orders_user_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.orders
    ADD CONSTRAINT orders_user_id_fkey FOREIGN KEY (user_id) REFERENCES public.users(id);


--
-- Name: payment_detail payment_detail_order_id_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.payment_detail
    ADD CONSTRAINT payment_detail_order_id_fkey FOREIGN KEY (order_id) REFERENCES public.orders(id);


--
-- PostgreSQL database dump complete
--

