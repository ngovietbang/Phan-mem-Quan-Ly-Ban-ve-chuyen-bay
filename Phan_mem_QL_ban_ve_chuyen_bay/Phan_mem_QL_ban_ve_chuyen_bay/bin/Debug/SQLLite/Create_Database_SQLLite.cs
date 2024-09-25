using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Phan_mem_QL_ban_ve_chuyen_bay.SQLLite
{
    /* Tạo Database, nếu chưa có thì dán lệnh này vào form main để chạy
     * 
     * 
    private void CreateDatabase()
    {
        // Đường dẫn tới thư mục cài đặt tệp .db trong thư mục hiện tại của ứng dụng
        string duongdan = Path.Combine(Application.StartupPath, "D:\\Mon hoc\\KIEM THU PHAN MEM\\Phan mem quan ly ban ve chuyen bay (KTPM)\\Phan_mem_QL_ban_ve_chuyen_bay\\Phan_mem_QL_ban_ve_chuyen_bay\\SQLLite\\QLBanVeChuyenBay.db");

        // Kiểm tra nếu file chưa tồn tại, tạo file mới
        if (!File.Exists(duongdan))
        {
            SQLiteConnection.CreateFile(duongdan);
            MessageBox.Show("Database được tạo tại: " + duongdan);
        }
        else
        {
            MessageBox.Show("Database đã tồn tại.");
        }
    }

    */
}
