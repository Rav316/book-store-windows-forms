using book_store.context;
using book_store.entity;
using book_store.util;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using SecurityContext = book_store.context.SecurityContext;

namespace book_store.dao
{
    internal class UserDao
    {
        public User FindByUsername(string username)
        {
            using (NpgsqlConnection connection = ConnectionManager.Open())
            {
                const string query = "SELECT * FROM users WHERE username = @username";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("username", username);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return BuildUser(reader);
                        }

                        return null;
                    };
                }
            }
        }

        public User FindByEmail(string email)
        {
            using NpgsqlConnection connection = ConnectionManager.Open();
            const string query = "SELECT * FROM users WHERE email = @email";

            using NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("email", email);

            using NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return BuildUser(reader);
            }

            return null;
        }

        public int Create(string username, string password, string email, string address)
        {
            using NpgsqlConnection connection = ConnectionManager.Open();
            const string query = """
                                INSERT INTO users(username, password, email, address)
                                VALUES
                                (@username, @password, @email, @address)
                                RETURNING id
                                """;

            using NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("username", username);
            command.Parameters.AddWithValue("password", password);
            command.Parameters.AddWithValue("email", email);
            command.Parameters.AddWithValue("address", address);

            return Convert.ToInt32(command.ExecuteScalar());

        }

        private User BuildUser(NpgsqlDataReader reader)
        {
            return new User(
                reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetString(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.IsDBNull(3) ? null : reader.GetString(3),
                reader.IsDBNull(4) ? null : reader.GetString(4),
                reader.IsDBNull(5) ? null : reader.GetString(5)
            );
        }
    }
}
