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
    public partial class FormQLSanBayTG : Form
    {
        Modify modify; // khai báo lớp
        ErrorProvider errorProvider;

        public FormQLSanBayTG()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void FormQLSanBayTG_Load(object sender, EventArgs e)
        {
            //gọi hàm hiển thị
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

        //load dữ liệu
        private void hienthi()
        {
            try
            {
                modify = new Modify();
                dgr_TG.DataSource = modify.loadTG();
                //header text
                dgr_TG.Columns[0].HeaderText = "Mã sân bay trung gian".ToUpper();
                dgr_TG.Columns[1].HeaderText = "Tên sân bay trung gian".ToUpper();
                dgr_TG.Columns[2].HeaderText = "Trạng thái".ToUpper();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //kiểm tra tồn tại mã sân bay trung gian
        private bool kt(string masbTG)
        {
            using (SQLiteConnection connection = Connection.getConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM SANBAYTG WHERE MASBTG = @masbtg";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@masbtg", masbTG);
                int count = Convert.ToInt32(command.ExecuteScalar());
                int dem = count;
                connection.Close();
                return dem == 1;
            }
        }

        //thêm
        private void bt_them_Click(object sender, EventArgs e)
        {
            string masbTG = tb_masbTG.Text.ToString().Trim();
            string tensbTG = tb_tenTG.Text.ToString().Trim();
            string trangthai = cb_trangthai.Text.ToString().Trim();

            try
            {
                //null mã sân bay trung gian
                if (string.IsNullOrWhiteSpace(masbTG))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_masbTG, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //đã tồn tại mã sân bay trung gian
                else if (kt(masbTG))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_masbTG, "Đã tồn tại mã sân bay trung gian");
                    MessageBox.Show("Lỗi: " + "Đã tồn tại mã sân bay trung gian", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //null tên sân bay trung gian
                else if (string.IsNullOrWhiteSpace(tensbTG))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_tenTG, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //null trạng thái
                else if (string.IsNullOrWhiteSpace(trangthai))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(cb_trangthai, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //thực hiện câu truy vấn 
                else
                {
                    ClearAllErrors(this.Controls);
                    string query = "INSERT INTO SANBAYTG VALUES(@masbtg, @tensbtg, @trangthai)";
                    using (SQLiteConnection connection = Connection.getConnection())
                    {
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        connection.Open();
                        command.Parameters.AddWithValue("@masbtg", masbTG);
                        command.Parameters.AddWithValue("@tensbtg", tensbTG);
                        command.Parameters.AddWithValue("@trangthai", trangthai);
                        command.ExecuteNonQuery();
                        connection.Close();
                        hienthi();
                    }
                    MessageBox.Show("Thêm thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_masbTG.Clear();
                    tb_tenTG.Clear();
                    cb_trangthai.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //thoát
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //cell click
        private void dgr_TG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgr_TG.Rows[e.RowIndex];
                tb_masbTG.Text = row?.Cells[0]?.Value.ToString().Trim();
                tb_tenTG.Text = row?.Cells[1]?.Value?.ToString()?.Trim();
                cb_trangthai.Text = row?.Cells[2]?.Value?.ToString()?.Trim();
            }
        }

        //làm mới
        private void bt_lammoi_Click(object sender, EventArgs e)
        {
            hienthi();
            ClearAllErrors(this.Controls);
            tb_masbTG.Clear();
            tb_tenTG.Clear();
            cb_trangthai.SelectedIndex = -1;
        }
    }
}
