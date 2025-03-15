using book_store.entity;
using book_store.util;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.dao
{
    internal class LanguageDao
    {
        public List<Language> FindAll()
        {
            using NpgsqlConnection connection = ConnectionManager.Open();

            List<Language> languages = new List<Language>();
            const string query = "SELECT * FROM language ORDER BY id";

            using NpgsqlCommand command = new NpgsqlCommand(query, connection);

            using NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Language language = BuildLanguage(reader);
                languages.Add(language);
            }

            return languages;
        }

        private Language BuildLanguage(NpgsqlDataReader reader)
        {
            return new Language(
                reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetString(1)
            );
        }
    }
}
