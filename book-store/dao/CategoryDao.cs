using book_store.entity;
using book_store.util;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dao
{
    internal class CategoryDao
    {
        public List<Category> FindAll()
        {
            using NpgsqlConnection connection = ConnectionManager.Open();

            List<Category> categories = new List<Category>();
            const string query = "SELECT * FROM category ORDER BY id";

            using NpgsqlCommand command = new NpgsqlCommand(query, connection);

            using NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Category category = BuildCategory(reader);
                categories.Add(category);
            }

            return categories;
        }

        private Category BuildCategory(NpgsqlDataReader reader)
        {
            return new Category(
                reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetString(1)
            );
        }
    }
}
