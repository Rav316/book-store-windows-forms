using book_store.entity;
using book_store.exception;
using book_store.util;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dao
{
    internal class BookDao
    {
        public List<Book> FindAllWithUserInfo(int userId)
        {
            using NpgsqlConnection connection = ConnectionManager.Open();
            
            List<Book> books = new List<Book>();
            const string query =
                """
                SELECT b.*,
                    CASE
                    WHEN f.book_id IS NOT NULL THEN TRUE
                    ELSE FALSE
                END AS is_favorite,
                CASE
                    WHEN c.book_id IS NOT NULL THEN TRUE
                    ELSE FALSE
                END AS is_in_cart,
                CONCAT(a.first_name, ' ', a.mid_name, ' ', a.last_name) as author_name
                FROM BOOK b
                LEFT JOIN favorites f
                ON b.id = f.book_id AND f.user_id = @userId
                LEFT JOIN cart c
                ON b.id = c.book_id AND c.user_id = @userId
                LEFT JOIN author a
                ON b.author_id = a.id
                """;

            using NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("userId", userId);

            using NpgsqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                Book book = BuildBook(reader);
                book.IsInFavorites = reader.GetBoolean(19);
                book.IsInCart = reader.GetBoolean(20);
                book.AuthorName = reader.GetString(21);
                books.Add(book);
            }

            return books;
            
        }

        public Book FindByIdForUser(int id, int userId)
        {
            using NpgsqlConnection connection = ConnectionManager.Open();

            const string query =
                """
                SELECT b.*,
                    CASE
                    WHEN f.book_id IS NOT NULL THEN TRUE
                    ELSE FALSE
                END AS is_favorite,
                CASE
                    WHEN c.book_id IS NOT NULL THEN TRUE
                    ELSE FALSE
                END AS is_in_cart,
                FROM BOOK b
                LEFT JOIN favorites f
                ON b.id = f.book_id AND f.user_id = @userId
                LEFT JOIN cart c
                ON b.id = c.book_id AND c.user_id = @userId
                ORDER BY b.id
                """;

            using NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("userId", userId);

            using NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Book book = BuildBook(reader);
                book.IsInFavorites = reader.GetBoolean(19);
                book.IsInCart = reader.GetBoolean(20);
                return book;
            }
            return null;
        }

        public (int, int) GetMinAndMaxPrice()
        {
            using NpgsqlConnection connection = ConnectionManager.Open();

            List<Book> books = new List<Book>();
            const string query =
                """
                SELECT MIN(price), MAX(price)
                FROM book
                """;

            using NpgsqlCommand command = new NpgsqlCommand(query, connection);

            using NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return (reader.GetInt32(0), reader.GetInt32(1));
            }
            return (0, 0);
        }

        private Book BuildBook(NpgsqlDataReader reader)
        {
            return new Book(
                // TODO переделать на именные параметры
                reader.GetInt32(0),
                reader.IsDBNull(1) ? 0.0 : reader.GetDouble(1),
                reader.IsDBNull(2) ? 0 : reader.GetInt32(2),
                reader.IsDBNull(3) ? null : reader.GetString(3),
                reader.IsDBNull(4) ? null : reader.GetString(4),
                reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                reader.IsDBNull(6) ? null : reader.GetString(6),
                reader.IsDBNull(7) ? 0 : reader.GetInt32(7),
                reader.IsDBNull(8) ? null : reader.GetString(8),
                reader.IsDBNull(9) ? 0 : reader.GetInt32(9),
                reader.IsDBNull(10) ? 0 : reader.GetInt32(10),
                reader.IsDBNull(11) ? 0 : reader.GetInt32(11),
                reader.IsDBNull(12) ? null : reader.GetString(12),
                reader.IsDBNull(13) ? 0 : reader.GetInt32(13),
                reader.IsDBNull(14) ? null : reader.GetString(14),
                reader.IsDBNull(15) ? 0 : reader.GetInt32(15),
                reader.IsDBNull(16) ? 0 : reader.GetInt32(16),
                reader.IsDBNull(17) ? 0 : reader.GetInt32(17),
                reader.IsDBNull(17) ? 0 : reader.GetInt32(18)
            );
        }
    }
}
