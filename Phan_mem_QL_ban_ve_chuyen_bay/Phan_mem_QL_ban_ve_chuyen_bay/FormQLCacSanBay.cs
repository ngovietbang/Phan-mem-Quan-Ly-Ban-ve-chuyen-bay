using Phan_mem_QL_ban_ve_chuyen_bay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phan_mem_QL_ban_ve_chuyen_bay
{
    public partial class FormQLCacSanBay : Form
    {
        Modify modify; // khai báo lớp
        ErrorProvider errorProvider;

        public FormQLCacSanBay()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void FormQLCacSanBay_Load(object sender, EventArgs e)
        {
            //gọi hàm hiển thị dữ liệu
            hienthi();
        }

        //clear lỗi
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

        //load dữ liệu bảng sân bay
        private void hienthi()
        {
            try
            {
                modify = new Modify();
                dgr_sb.DataSource = modify.loadSanbay();
                //header text
                dgr_sb.Columns[0].HeaderText = "Mã sân bay".ToUpper();
                dgr_sb.Columns[1].HeaderText = "Tên sân bay".ToUpper();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Error" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //kiểm tra tồn tại mã sb
        private bool kt(string masb)
        {
            using (SQLiteConnection connection = Connection.getConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM SANBAY WHERE MASANBAY = @masb";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@masb", masb);
                int count = Convert.ToInt32(command.ExecuteScalar());
                int dem = count;
                connection.Close();
                return dem == 1;
            }
        }

        //nút thêm
        private void bt_them_Click(object sender, EventArgs e)
        {
            string masb = tb_masb.Text.ToString().Trim();
            string tensb = tb_tensb.Text.ToString().Trim();

            try
            {
                //null mã sân bay
                if (string.IsNullOrWhiteSpace(masb))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_masb, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //đã tồn tại mã sân bay
                else if (kt(masb))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_masb, "Đã tồn tại mã sân bay");
                    MessageBox.Show("Lỗi: " + "Đã tồn tại mã sân bay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //null tên sân bay
                else if (string.IsNullOrWhiteSpace(tensb))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_tensb, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //thực hiện câu truy vấn 
                else
                {
                    ClearAllErrors(this.Controls);
                    string query = "INSERT INTO SANBAY VALUES(@masb, @tensb)";
                    using (SQLiteConnection connection = Connection.getConnection())
                    {
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        connection.Open();
                        command.Parameters.AddWithValue("@masb", masb);
                        command.Parameters.AddWithValue("@tensb", tensb);
                        command.ExecuteNonQuery();
                        connection.Close();
                        hienthi();
                    }
                    MessageBox.Show("Thêm thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_masb.Clear();
                    tb_tensb.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //cell click
        private void dgr_sb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgr_sb.Rows[e.RowIndex];
                tb_masb.Text = row?.Cells[0]?.Value.ToString().Trim();
                tb_tensb.Text = row?.Cells[1]?.Value?.ToString()?.Trim();
            }
        }

        //sửa
        private void bt_sua_Click(object sender, EventArgs e)
        {
            string masb = tb_masb.Text.ToString().Trim();
            string tensb = tb_tensb.Text.ToString().Trim();

            try
            {
                //null mã sân bay
                if (string.IsNullOrWhiteSpace(masb))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_masb, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //không tìm thấy mã sân bay
                else if (!kt(masb))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_masb, "Không tìm thấy mã sân bay");
                    MessageBox.Show("Lỗi: " + "Không tìm thấy mã sân bay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //null tên sân bay
                else if (string.IsNullOrWhiteSpace(tensb))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_tensb, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //thực hiện câu truy vấn 
                else
                {
                    ClearAllErrors(this.Controls);
                    string query = "UPDATE SANBAY SET TENSANBAY = @tensb WHERE MASANBAY = @masb";
                    using (SQLiteConnection connection = Connection.getConnection())
                    {
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        connection.Open();
                        command.Parameters.AddWithValue("@masb", masb);
                        command.Parameters.AddWithValue("@tensb", tensb);
                        command.ExecuteNonQuery();
                        connection.Close();
                        hienthi();
                    }
                    MessageBox.Show("Sửa thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_masb.Clear();
                    tb_tensb.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //xóa
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string masb = tb_masb.Text.ToString().Trim();

            try
            {
                //null mã sân bay
                if (string.IsNullOrWhiteSpace(masb))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_masb, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //không tìm thấy mã sân bay
                else if (!kt(masb))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_masb, "Không tìm thấy mã sân bay");
                    MessageBox.Show("Lỗi: " + "Không tìm thấy mã sân bay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //thực hiện câu truy vấn 
                else
                {
                    ClearAllErrors(this.Controls);

                    // Hiển thị thông báo xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    // Kiểm tra lựa chọn của người dùng
                    if (result == DialogResult.Yes)
                    {
                        // Thực hiện hành động xóa dữ liệu
                        string query = "DELETE FROM SANBAY WHERE MASANBAY = @masb";
                        using (SQLiteConnection connection = Connection.getConnection())
                        {
                            SQLiteCommand command = new SQLiteCommand(query, connection);
                            connection.Open();
                            command.Parameters.AddWithValue("@masb", masb);
                            command.ExecuteNonQuery();
                            connection.Close();
                            hienthi();
                        }
                        MessageBox.Show("Xóa thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_masb.Clear();
                        tb_tensb.Clear();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //làm mới
        private void bt_lammoi_Click(object sender, EventArgs e)
        {
            hienthi();
            ClearAllErrors(this.Controls);
            tb_masb.Clear();
            tb_tensb.Clear();
        }

        //thoát
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
