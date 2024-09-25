using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_QL_ban_ve_chuyen_bay.SQLLite
{
    /*Câu lệnh tạo bảng sql Lite
     * 
    private void TaoBang()
    {
        //string duongdan = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SQLLite", "QLBanVeChuyenBay.db");
        string duongdan = Path.Combine(Application.StartupPath, "D:\\Mon hoc\\KIEM THU PHAN MEM\\Phan mem quan ly ban ve chuyen bay (KTPM)\\Phan_mem_QL_ban_ve_chuyen_bay\\Phan_mem_QL_ban_ve_chuyen_bay\\SQLLite\\QLBanVeChuyenBay.db");
        string connectionString = $"Data Source={duongdan};Version=3;";

        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            connection.Open();

            // Tạo bảng TAIKHOAN
            string createTableTAIKHOAN = @"
                    CREATE TABLE IF NOT EXISTS TAIKHOAN (
                        USERNAME TEXT NOT NULL UNIQUE, 
                        PASSWORD TEXT NOT NULL, 
                        HOVATEN TEXT NOT NULL, 
                        NGAYSINH TEXT NOT NULL, 
                        GIOITINH TEXT, 
                        DIACHI TEXT NOT NULL, 
                        SODIENTHOAI TEXT NOT NULL, 
                        CHUCVU TEXT NOT NULL, 
                        EMAIL TEXT NOT NULL, 
                        PRIMARY KEY (USERNAME)
                    );";

            ExecuteSQLCommand(connection, createTableTAIKHOAN);

            // Tạo bảng LICHCHUYENBAY
            string createTableLICHCHUYENBAY = @"
                    CREATE TABLE IF NOT EXISTS LICHCHUYENBAY (
                        MACHUYENBAY TEXT NOT NULL,
                        GIAVE REAL NOT NULL, 
                        SANBAYDI TEXT NOT NULL, 
                        SANBAYDEN TEXT NOT NULL, 
                        SANBAYTRUNGGIAN TEXT, 
                        THOIGIANDUNG TEXT NOT NULL, 
                        NGAYGIO TEXT NOT NULL, 
                        THOIGIANBAY TEXT NOT NULL, 
                        SOLUONGGHEHANG1 REAL NOT NULL, 
                        SOLUONGGHEHANG2 REAL NOT NULL, 
                        GHICHU TEXT, 
                        PRIMARY KEY (MACHUYENBAY)
                    );";

            ExecuteSQLCommand(connection, createTableLICHCHUYENBAY);

            // Tạo bảng VECHUYENBAY
            string createTableVECHUYENBAY = @"
                    CREATE TABLE IF NOT EXISTS VECHUYENBAY (
                        MAVE TEXT NOT NULL UNIQUE, 
                        MACHUYENBAY TEXT NOT NULL, 
                        HANHKHACH TEXT NOT NULL, 
                        CMND TEXT NOT NULL UNIQUE, 
                        DIENTHOAI TEXT NOT NULL, 
                        HANGVE TEXT NOT NULL, 
                        GIATIEN REAL NOT NULL, 
                        PRIMARY KEY (MAVE),
                        FOREIGN KEY (MACHUYENBAY) REFERENCES LICHCHUYENBAY(MACHUYENBAY)
                    );";

            ExecuteSQLCommand(connection, createTableVECHUYENBAY);

            // Tạo bảng PHIEUDATCHO
            string createTablePHIEUDATCHO = @"
                    CREATE TABLE IF NOT EXISTS PHIEUDATCHO (
                        MAPHIEUDAT TEXT NOT NULL UNIQUE, 
                        MACHUYENBAY TEXT NOT NULL, 
                        HANHKHACH TEXT NOT NULL, 
                        CMND TEXT NOT NULL UNIQUE, 
                        DIENTHOAI TEXT NOT NULL, 
                        HANGVE TEXT NOT NULL, 
                        GIATIEN REAL NOT NULL, 
                        PRIMARY KEY (MAPHIEUDAT),
                        FOREIGN KEY (MACHUYENBAY) REFERENCES LICHCHUYENBAY(MACHUYENBAY)
                    );";

            ExecuteSQLCommand(connection, createTablePHIEUDATCHO);

            // Tạo bảng DOANHTHUTHANG
            string createTableDOANHTHUTHANG = @"
                    CREATE TABLE IF NOT EXISTS DOANHTHUTHANG (
                        THANG TEXT NOT NULL, 
                        MACHUYENBAY TEXT NOT NULL, 
                        SOVE REAL NOT NULL, 
                        DOANHTHU REAL NOT NULL, 
                        TILE TEXT
                    );";

            ExecuteSQLCommand(connection, createTableDOANHTHUTHANG);

            // Tạo bảng DOANHTHUNAM
            string createTableDOANHTHUNAM = @"
                    CREATE TABLE IF NOT EXISTS DOANHTHUNAM (
                        NAM TEXT NOT NULL, 
                        THANG TEXT NOT NULL, 
                        SOCHUYENBAY REAL NOT NULL, 
                        DOANHTHU REAL NOT NULL, 
                        TILE TEXT
                    );";

            ExecuteSQLCommand(connection, createTableDOANHTHUNAM);

            // Tạo bảng SANBAY
            string createTableSANBAY = @"
                    CREATE TABLE IF NOT EXISTS SANBAY (
                        MASANBAY TEXT NOT NULL,
                        TENSANBAY TEXT NOT NULL,
                        PRIMARY KEY (MASANBAY)
                    );";

            ExecuteSQLCommand(connection, createTableSANBAY);

            connection.Close();
        }
    }

    // Hàm để thực hiện các lệnh SQL
        private static void ExecuteSQLCommand(SQLiteConnection connection, string sqlCommand)
        {
            using (SQLiteCommand command = new SQLiteCommand(sqlCommand, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Executed: " + sqlCommand.Substring(0, Math.Min(sqlCommand.Length, 50)) + "...");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error executing SQL: " + ex.Message);
                }
            }
        }

    */

}
