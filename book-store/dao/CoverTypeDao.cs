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
    internal class CoverTypeDao
    {
        public List<CoverType> FindAll()
        {
            using NpgsqlConnection connection = ConnectionManager.Open();

            List<CoverType> coverTypes = new List<CoverType>();
            const string query = "SELECT * FROM cover_type ORDER BY id";

            using NpgsqlCommand command = new NpgsqlCommand(query, connection);

            using NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                CoverType coverType = BuildCoverType(reader);
                coverTypes.Add(coverType);
            }

            return coverTypes;
        }

        private CoverType BuildCoverType(NpgsqlDataReader reader)
        {
            return new CoverType(
                reader.GetInt32(0),
                reader.IsDBNull(1) ? null : reader.GetString(1)
            );
        }
    }
}
