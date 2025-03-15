using book_store.entity;
using book_store.util;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dao
{
    internal class AuthorDao
    {
        public Author FindById(int id)
        {
            using NpgsqlConnection connection = ConnectionManager.Open();

            const string query =
                """
                SELECT*
                FROM author a
                WHERE a.id = @id
                ORDER BY id
                """;

            using NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);

            using NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return BuildAuthor(reader);
            }
            return null;
        }

        private Author BuildAuthor(NpgsqlDataReader reader)
        {
            return new Author(
                reader.GetInt32("id"),
                reader.IsDBNull("first_name") ? null : reader.GetString("first_name"),
                reader.IsDBNull("middle_name") ? null : reader.GetString("middle_name"),
                reader.IsDBNull("last_name") ? null : reader.GetString("last_name"),
                reader.IsDBNull("birth_year") ? DateOnly.FromDateTime(DateTime.Now) : DateOnly.FromDateTime(reader.GetDateTime("birth_year")),
                reader.IsDBNull("death_year") ? DateOnly.FromDateTime(DateTime.Now) : DateOnly.FromDateTime(reader.GetDateTime("death_year")),
                reader.IsDBNull("nationality") ? null : reader.GetString("nationality")
            );
        }
    }
}
