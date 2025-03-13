using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.util
{
    internal sealed class ConnectionManager
    {
        private static string HOST = "localhost";
        private static string NAME = "book_store_windows_forms";
        private static string PASSWORD = "1";
        private static string USERNAME = "postgres";


        private ConnectionManager() { }

        public static NpgsqlConnection Open()
        {
            NpgsqlConnection connection = new NpgsqlConnection(
                $"Server={HOST}; Port=5432; DataBase={NAME}; User Id={USERNAME}; Password={PASSWORD}"
            );
            connection.Open();
            return connection;
        }
    }
}
