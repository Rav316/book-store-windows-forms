INSERT INTO publisher (id, name) VALUES
(1, 'Oxford University Press'),
(2, 'Vintage Classics'),
(3, 'Penguin Classics');

INSERT INTO cover_type (id, type) VALUES
    (1, 'Paperback');

INSERT INTO language (id, language) VALUES
    (1, 'EN');

INSERT INTO book (id, author_id, rating, price, publisher_id, series, year_of_publishing, isbn, number_of_pages, size, cover_type_id, circulation, weight, age_restrictions, name, category_id, description, language_id, image_path)
VALUES
    (1, 1, 4.5, 15, 1, NULL, 1869, '9780199536117', 1296, '6.1 x 1.9 x 9.2 inches', 1, 100000, 1588, 0, 'War and Peace', 1, 'A monumental novel that explores the impact of the Napoleonic Wars on Tsarist Russia.', 1, '71wXZB-VtBL._AC_UF1000,1000_QL80_.jpg'),
    (2, 2, 4.3, 12, 2, NULL, 1866, '9780099503271', 672, '5.1 x 1.8 x 7.8 inches', 1, 100000, 672, 0, 'Crime and Punishment', 1, 'A psychological thriller that delves into the mind of a murderer.', 1, 'Crimeandpunishmentcover.png'),
    (3, 3, 4.2, 10, 3, NULL, 1813, '9780141439562', 480, '5.1 x 1.3 x 7.8 inches', 1, 100000, 480, 0, 'Pride and Prejudice', 1, 'A romantic novel that explores the themes of love, marriage, and social class.', 1, 'MV5BMTA1NDQ3NTcyOTNeQTJeQWpwZ15BbWU3MDA0MzA4MzE@._V1_.jpg'),
    (4, 4, 4.1, 14, 3, NULL, 1859, '9780141439593', 944, '5.1 x 2 x 7.8 inches', 1, 100000, 944, 0, 'A Tale of Two Cities', 1, 'A historical novel set in the French Revolution that explores the themes of duality and resurrection.', 1, 'images.jpg'),
    (5, 5, 4.0, 11, 1, NULL, 1884, '9780199535543', 416, '5.1 x 0.9 x 7.8 inches', 1, 100000, 416, 0, 'Adventures of Huckleberry Finn', 1, 'A satirical novel that explores the themes of racism and morality.', 1, '91sBZnKzEfL._AC_UF1000,1000_QL80_.jpg'),
    (6, 6, 3.9, 13, 3, NULL, 1851, '9780141439814', 672, '5.1 x 1.7 x 7.8 inches', 1, 100000, 672, 0, 'Moby-Dick', 1, 'An epic novel that explores the themes of obsession and the nature of good and evil.', 1, '81R91ODA9DL._AC_UF1000,1000_QL80_.jpg'),
    (7, 7, 3.8, 16, 3, NULL, 1857, '9780140449281', 512, '5.1 x 1.3 x 7.8 inches', 1, 100000, 512, 0, 'Madame Bovary', 1, 'A realist novel that explores the themes of adultery and the nature of human desire.', 1, '41Of4Xao87L._AC_UF1000,1000_QL80_.jpg'),
    (8, 8, 3.7, 12, 3, NULL, 1861, '9780140434234', 864, '5.1 x 2 x 7.8 inches', 1, 100000, 864, 0, 'Silas Marner', 1, 'A pastoral novel that explores the themes of redemption and the nature of human relationships.', 1, '71ZvgiUWuJL._AC_UF1000,1000_QL80_.jpg'),
    (9, 9, 3.6, 10, 3, NULL, 1874, '9780140434241', 448, '5.1 x 0.9 x 7.8 inches', 1, 100000, 448, 0, 'Far from the Madding Crowd', 1, 'A pastoral novel that explores the themes of love and the nature of human relationships.', 1, 'MV5BNzI4NzUwNDgwN15BMl5BanBnXkFtZTgwNTI3MjMwNTE@._V1_.jpg'),
    (10, 10, 3.5, 13, 3, NULL, 1847, '9780141439548', 448, '5.1 x 0.9 x 7.8 inches', 1, 100000, 448, 0, 'Wuthering Heights', 1, 'A gothic novel that explores the themes of love and the nature of human relationships.', 1, '81dvA4tU0rL._AC_UF1000,1000_QL80_.jpg');

SELECT setval('author_id_seq', (SELECT MAX(id) FROM author));
SELECT setval('publisher_id_seq', (SELECT MAX(id) FROM publisher));
SELECT setval('cover_type_id_seq', (SELECT MAX(id) FROM cover_type));
SELECT setval('language_id_seq', (SELECT MAX(id) FROM language));
SELECT setval('book_id_seq', (SELECT MAX(id) FROM book));