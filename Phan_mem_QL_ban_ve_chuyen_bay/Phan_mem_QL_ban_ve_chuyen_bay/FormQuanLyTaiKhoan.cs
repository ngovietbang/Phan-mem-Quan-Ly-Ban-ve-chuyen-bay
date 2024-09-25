using Phan_mem_QL_ban_ve_chuyen_bay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_mem_QL_ban_ve_chuyen_bay
{
    //Form dành cho chức vụ admin
    public partial class FormQuanLyTaiKhoan : Form
    {
        
        Modify modify; //khai báo lớp modify
        private ErrorProvider errorProvider; //tạo một thông báo lỗi 


        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void FormQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            //gọi hàm load bảng tài khoản
            loadTaiKhoan();
            dgr_taikhoan.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold); //thay đổi chữ và sizze

        }

        //Clear lỗi
        private void ClearAllErrors(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is System.Windows.Forms.TextBox || control is System.Windows.Forms.ComboBox)
                {
                    errorProvider.SetError(control, string.Empty);
                }

                // Nếu control là container, lặp đệ quy qua các điều khiển con
                if (control.Controls.Count > 0)
                {
                    ClearAllErrors(control.Controls);
                }
            }
        }

        //hàm tải dữ liệu vào data grid view
        private void loadTaiKhoan()
        {
            modify = new Modify();
            dgr_taikhoan.DataSource = modify.loadTaiKhoan();

            //Chữ tiêu đề cột
            dgr_taikhoan.Columns[0].HeaderText = "Tài khoản";
            dgr_taikhoan.Columns[1].HeaderText = "Mật khẩu";
            dgr_taikhoan.Columns[2].HeaderText = "Họ và tên";
            dgr_taikhoan.Columns[3].HeaderText = "Ngày sinh";
            dgr_taikhoan.Columns[4].HeaderText = "Giới tính";
            dgr_taikhoan.Columns[5].HeaderText = "Địa chỉ";
            dgr_taikhoan.Columns[6].HeaderText = "Số điện thoại";
            dgr_taikhoan.Columns[7].HeaderText = "Chức vụ";
            dgr_taikhoan.Columns[8].HeaderText = "Email";
        }

        //nút thêm tài khoản
        private void bt_them_Click_1(object sender, EventArgs e)
        {
            string username = tb_tk.Text.ToString().Trim();
            string password = tb_mk.Text.ToString().Trim();
            string hovaten = tb_hoten.Text.ToString().Trim();
            DateTime ngaysinh = dtp_ns.Value;
            string gioitinh = cb_gt.Text.ToString().Trim();
            string diachi = tb_dc.Text.ToString().Trim();
            string sdt = tb_sdt.Text.ToString().Trim();
            string chucvu = cb_cv.Text.ToString().Trim();
            string email = tb_email.Text.ToString().Trim();

            try
            {

                if (string.IsNullOrWhiteSpace(username))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_tk, "Khoon");
                }
                else
                {
                    try
                    {
                        //thêm tài khoản
                        using (SQLiteConnection connection = Connection.getConnection())
                        {
                            string query = "insert into TAIKHOAN values(@username, @password, @hovaten, @ngaysinh, @gioitinh, @diachi, @sodienthoai, @chucvu, @email)";

                            connection.Open();
                            SQLiteCommand command = new SQLiteCommand(query, connection);
                            command.Parameters.AddWithValue("@username", username);
                            command.Parameters.AddWithValue("@password", password);
                            command.Parameters.AddWithValue("@hovaten", hovaten);
                            command.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                            command.Parameters.AddWithValue("@gioitinh", gioitinh);
                            command.Parameters.AddWithValue("@diachi", diachi);
                            command.Parameters.AddWithValue("@sodienthoai", sdt);
                            command.Parameters.AddWithValue("@chucvu", chucvu);
                            command.Parameters.AddWithValue("@email", email);
                            command.ExecuteNonQuery();
                            connection.Close();

                            loadTaiKhoan();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
