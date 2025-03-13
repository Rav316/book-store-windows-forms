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
        private static readonly Lazy<UserDao> _instance = new(() => new UserDao());
        private UserDao() { }

        public static UserDao Instance => _instance.Value;

        public User Authenticate(string username, string password)
        {
            try
            {
                using NpgsqlConnection connection = ConnectionManager.Open();
                const string query = "SELECT * FROM users WHERE username = @username";

                using NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("username", username);

                using NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    User user = BuildUser(reader);
                    if(PasswordEncoder.Decode(password, user.Password))
                    {
                        SecurityContext.authentication = user;
                    }
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Error during authentication: {ex.Message}");
            }

            return null;
        }

        private User BuildUser(NpgsqlDataReader reader)
        {
            return new User(
                reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetString(1),
                reader.IsDBNull(2) ? null : reader.GetString(2),
                reader.IsDBNull(3) ? null : reader.GetString(3),
                reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                reader.IsDBNull(5) ? null : reader.GetString(5)
            );
        }
    }
}
