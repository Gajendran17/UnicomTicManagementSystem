using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom_TIC_Management_System.Data
{
    internal static class DBConfig
    {
        private static string ConnectionString = "Data Source=UnicomTicDB.db;version=3;";

        public static SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            return conn;
        }

    }
}
