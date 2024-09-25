using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_QL_ban_ve_chuyen_bay.Class
{
    class Connection
    {
        private static string duongdan = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SQLLite", "QLBanVeChuyenBay.db");
        private static string stringConnection = $"Data Source={duongdan};Version=3";
        public static SQLiteConnection getConnection()
        {
            return new SQLiteConnection(stringConnection);
        }
    }
}
