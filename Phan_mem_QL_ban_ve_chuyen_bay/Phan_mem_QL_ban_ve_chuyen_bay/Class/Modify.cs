using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_mem_QL_ban_ve_chuyen_bay.Class
{
    class Modify
    {
        //vùng tài khoản
        #region taikhoan
        //hiển thị dữ liệu bảng tài khoản
        public DataTable loadTaiKhoan()
        {
            DataTable dataTable = new DataTable();
            //câu truy vấn
            string query = "SELECT * FROM TAIKHOAN";
            using (SQLiteConnection connection = Connection.getConnection())
            {
                connection.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }
        #endregion


        //vùng Lịch chuyến bay
        #region LichChuyenBay

        public DataTable loadLichChuyenBay()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM LICHCHUYENBAY";
            using (SQLiteConnection connection = Connection.getConnection())
            {
                connection.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable ;
        }
        #endregion


        //vùng sân bay
        #region san bay
 
        public DataTable loadSanbay()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM SANBAY";
            using (SQLiteConnection connection = Connection.getConnection())
            {
                connection.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }
        #endregion


        //vùng sân bay trung gian
        #region san bay trung gian
        public DataTable loadTG()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM SANBAYTG";
            using (SQLiteConnection connection = Connection.getConnection())
            {
                connection.Open();
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, connection);
                dataAdapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }
        #endregion

    }
}
