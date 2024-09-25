using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phan_mem_QL_ban_ve_chuyen_bay.Class;

namespace Phan_mem_QL_ban_ve_chuyen_bay
{
    public partial class FormDangNhap : Form
    {

        public FormDangNhap()
        {
            InitializeComponent();
            //bỏ task bar và border form
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // Tạo text cho Lưu tài khoản và mật khẩu
            if (Properties.Settings.Default.Rememberme)
            {
                tb_tk.Text = Properties.Settings.Default.Username;
                tb_matkhau.Text = Properties.Settings.Default.Password;
                cb_ghinho.Checked = true;
            }
        }


        //hàm kiểm tra đăng nhập
        private bool ktDN(string username, string password)
        {
            //kiểm tra
            try
            {
                //câu truy vấn      
                using (SQLiteConnection connection = Connection.getConnection())
                {
                    string query = "SELECT COUNT(*) FROM TAIKHOAN WHERE USERNAME = @username AND PASSWORD = @password";
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(query,connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    int dem = count;
                    connection.Close();
                    return dem == 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //nút thoát
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //nút đăng nhập
        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            string username = tb_tk.Text.ToString().Trim();
            string password = tb_matkhau.Text.ToString().Trim();

            try
            {
                //kiểm tra dữ liệu tài khoản
                if (ktDN(username, password))
                {
                    //check nút ghi nhớ
                    if (cb_ghinho.Checked)
                    {
                        // lưu tài khoản và mật khẩu
                        Properties.Settings.Default.Username = username;
                        Properties.Settings.Default.Password = password;
                        Properties.Settings.Default.Rememberme = true;
                    }
                    else
                    {
                        // xóa lưu trữ trên text box khi không checked
                        Properties.Settings.Default.Username = "";
                        Properties.Settings.Default.Password = "";
                        Properties.Settings.Default.Rememberme = false;
                    }
                    //lưu
                    Properties.Settings.Default.Save();

                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //mở form main
                    FormMain f = new FormMain();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
