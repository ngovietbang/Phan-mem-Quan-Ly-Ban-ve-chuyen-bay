using Phan_mem_QL_ban_ve_chuyen_bay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Phan_mem_QL_ban_ve_chuyen_bay
{
    public partial class FormNhanLichChuyenBay : Form
    {
        Modify modify; //khai báo lớp
        ErrorProvider errorProvider; //khai báo thông báo lỗi

        public FormNhanLichChuyenBay()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();

        }

        private void FormNhanLichChuyenBay_Load(object sender, EventArgs e)
        {
            //gọi hàm hiển thị
            hienthi();
            
            //load dũ liệu vào combobox sân bay đi và đến
            loadCB();
            loadCB2();
            //load dữ liệu vào combo box sân bay trung gian
            loadCBTG();
        }

        //load dữ liệu từ sân bay vào combobox
        private void loadCB()
        {
            string query = "SELECT TENSANBAY FROM SANBAY";
            using (SQLiteConnection connection = Connection.getConnection())
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                cb_sanbaydi.Items.Clear();
                while (reader.Read())
                {
                    // Lấy dữ liệu từ cột "CustomerName"
                    string tensb = reader["TENSANBAY"].ToString();

                    // Thêm dữ liệu vào ComboBox
                    cb_sanbaydi.Items.Add(tensb);
                }
                connection.Close();
            }
        }

        // load vaò combobox san bay đến       
        private void loadCB2()
        {
            string query = "SELECT TENSANBAY FROM SANBAY";
            using (SQLiteConnection connection = Connection.getConnection())
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                cb_sanbayden.Items.Clear();
                while (reader.Read())
                {
                    // Lấy dữ liệu từ cột "CustomerName"
                    string tensb = reader["TENSANBAY"].ToString();

                    // Thêm dữ liệu vào ComboBox
                    cb_sanbayden.Items.Add((tensb));
                }
                connection.Close();
            }
        }

        //load dữ liệu từ sân bay trung gian  vào combobox sân bay trung gian
        private void loadCBTG()
        {
            string query = "SELECT TENSBTG FROM SANBAYTG";
            using (SQLiteConnection connection = Connection.getConnection())
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(query, connection);
                SQLiteDataReader reader = command.ExecuteReader();
                cb_trunggian.Items.Clear();
                while (reader.Read())
                {
                    // Lấy dữ liệu từ cột "CustomerName"
                    string tensbTG = reader["TENSBTG"].ToString();

                    // Thêm dữ liệu vào ComboBox
                    cb_trunggian.Items.Add(tensbTG);
                }
                connection.Close();
            }
        }

        //Clear lỗi
        private void ClearAllErrors(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is System.Windows.Forms.TextBox || control is System.Windows.Forms.ComboBox || control is System.Windows.Forms.DateTimePicker)
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

        //hàm hiển thị 
        private void hienthi()
        {
            try
            {
                modify = new Modify();
                dgr_cb.DataSource = modify.loadLichChuyenBay();
                //
                dgr_cb.Columns[0].HeaderText = "Mã chuyến bay".ToUpper();
                dgr_cb.Columns[1].HeaderText = "Giá vé".ToUpper();
                dgr_cb.Columns[2].HeaderText = "Sân bay đi".ToUpper();
                dgr_cb.Columns[3].HeaderText = "Sân bay đến".ToUpper();
                dgr_cb.Columns[4].HeaderText = "Sân bay trung gian".ToUpper();
                dgr_cb.Columns[5].HeaderText = "Thời gian dừng".ToUpper();
                dgr_cb.Columns[6].HeaderText = "Ngày giờ".ToUpper();
                dgr_cb.Columns[7].HeaderText = "Thời gian bay".ToUpper();
                dgr_cb.Columns[8].HeaderText = "Lượng Ghế hạng 1".ToUpper();
                dgr_cb.Columns[9].HeaderText = "Lượng Ghế hạng 2".ToUpper();
                dgr_cb.Columns[10].HeaderText = "Ghi chú".ToUpper();

                //
                dgr_cb.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray; // Màu nền
                dgr_cb.EnableHeadersVisualStyles = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //vùng thêm
        #region them lich chuyen bay

        //hàm lấy mã tự động -> mã tiếp theo CÓ dạng: CB<số++>
        private string GenerateNextId()
        {
            using (SQLiteConnection connection = Connection.getConnection())
            {
                connection.Open();
                // Lấy ID lớn nhất hiện tại
                string query = "SELECT MAX(CAST(SUBSTR(MACHUYENBAY, 3) AS INTEGER)) FROM LICHCHUYENBAY";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    int nextId = (result != DBNull.Value ? Convert.ToInt32(result) : 0) + 1; // Tăng thêm 1
                    return "CB" + nextId.ToString();
                }

            }
        }

        //nút thêm lịch chuyến bay
        private void bt_them_Click(object sender, EventArgs e)
        {
            string macb = GenerateNextId();
            string giave = tb_giave.Text.ToString().Trim(); 
            string sanbaydi = cb_sanbaydi.Text.ToString().Trim();
            string sanbayden = cb_sanbayden.Text.ToString().Trim();
            string sanbayTG = cb_trunggian.Text.ToString().Trim();
            TimeSpan TGdung = dtp_tgdung.Value.TimeOfDay;
            DateTime ngaygio = dpt_ngaygio.Value;
            TimeSpan TGBay = dtp_tgbay.Value.TimeOfDay;
            string SLGhe1 = tb_ghe1.Text.ToString().Trim();
            string SLGhe2 = tb_ghe2.Text.ToString().Trim();
            string ghichu = rtb_ghichu.Text.ToString().Trim();

            //kiểm tra định dạng số
            bool kt_giave = decimal.TryParse(giave, out decimal kq1);//kiểm tra định dạng giá vé
            bool kt_slghe1 = decimal.TryParse(SLGhe1, out decimal kq2); //kiểm tra định dạng số lượng ghế hạng 1
            bool kt_slghe2 = decimal.TryParse(SLGhe2, out decimal kq3); //kiểm tra định dạng số lượng ghế hạng 2

            //kiểm tra thời gian
            TimeSpan BayToiThieu = new TimeSpan(0, 30, 0); //thời gian bay tối thiểu
            TimeSpan timeDungMin = new TimeSpan(0, 10, 0); //thời gian dừng min
            TimeSpan timeDungMax = new TimeSpan(0, 21, 0); //thời gian dừng max

            try
            {
                //mã chuyến bay được tạo tự động

                //lỗi null giá vé
                if (string.IsNullOrWhiteSpace(giave)) 
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_giave, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi giá vé không đúng định dạng số, và lỗi < 0
                else if (!kt_giave || kq1 < 0)
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_giave, "Giá vé không hợp lệ");
                    MessageBox.Show("Lỗi: " + "Giá vé không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi null sân bay đi 
                else if (string.IsNullOrWhiteSpace(sanbaydi))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(cb_sanbaydi, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi null sân bay đến
                else if (string.IsNullOrWhiteSpace(sanbayden))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(cb_sanbayden, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi sân bay đến trùng sân bay đi
                else if (sanbayden == sanbaydi)
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(cb_sanbayden, "Sân bay đến không được trùng với sân bay đi");
                    MessageBox.Show("Lỗi: " + "Sân bay đến không được trùng với sân bay đi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // --> điệu kiện đề bài p1: thời gian bay tối thiểu là 30 phút  
                else if (TGBay < BayToiThieu)
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(dtp_tgbay, "Thời gian bay tối thiểu là 30 phút");
                    MessageBox.Show("Lỗi: " + "Thời gian bay tối thiểu là 30 phút", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi null sân bay trung gian
                else if (string.IsNullOrWhiteSpace(sanbayTG))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(cb_trunggian, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // --> Điều kiện đề bài p2: Thời gian dừng trong khoảng 10 -> 20 phút
                else if (TGdung < timeDungMin || TGdung > timeDungMax)
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(dtp_tgdung, "Thời gian dừng chỉ có thể dừng từ 10 đến 20 phút");
                    MessageBox.Show("Lỗi: " + "Thời gian dừng chỉ có thể dừng từ 10 đến 20 phút", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi null số lượng ghế hạng 1
                else if (string.IsNullOrWhiteSpace(SLGhe1))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_ghe1, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi SL ghế hạng 1 không đúng dịnh dạng số và < 0
                else if (!kt_slghe1 || kq2 < 0)
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_ghe1, "Dữ liệu số lượng ghế hạng một nhập không hợp lệ");
                    MessageBox.Show("Lỗi: " + "Dữ liệu số lượng ghế hạng một nhập không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi null số lượng ghế hạng 2
                else if (string.IsNullOrWhiteSpace(SLGhe2))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_ghe2, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi SL ghế hạng 2 không đúng dịnh dạng số và < 0
                else if (!kt_slghe2 || kq3 < 0)
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_ghe2, "Dữ liệu số lượng ghế hạng hai nhập không hợp lệ");
                    MessageBox.Show("Lỗi: " + "Dữ liệu số lượng ghế hạng hai nhập không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //thực hiện khi thỏa mãn
                else
                {
                    ClearAllErrors(this.Controls);

                    string query = "INSERT INTO LICHCHUYENBAY VALUES (@macb, @giave, @sanbaydi, @sanbayden, @sanbayTG, @TGdung, @ngaygio, @TGbay, @SLGhe1, @SLGhe2, @ghichu)";
                    using (SQLiteConnection connection = Connection.getConnection())
                    {
                        connection.Open();
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        command.Parameters.AddWithValue("@macb", macb);
                        command.Parameters.AddWithValue("@giave", giave);
                        command.Parameters.AddWithValue("@sanbaydi", sanbaydi);
                        command.Parameters.AddWithValue("@sanbayden", sanbayden);
                        command.Parameters.AddWithValue("@sanbayTG", sanbayTG);
                        command.Parameters.AddWithValue("@TGdung", TGdung);
                        command.Parameters.AddWithValue("@ngaygio", ngaygio);
                        command.Parameters.AddWithValue("@TGbay", TGBay);
                        command.Parameters.AddWithValue("@SLGhe1", SLGhe1);
                        command.Parameters.AddWithValue("@SLGhe2", SLGhe2);
                        command.Parameters.AddWithValue("@ghichu", ghichu);
                        command.ExecuteNonQuery();
                        connection.Close();
                        clearText();
                        MessageBox.Show("Thêm thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienthi();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion


        //cell click
        private void dgr_cb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgr_cb.Rows[e.RowIndex];
                tb_macb.Text = row?.Cells[0]?.Value.ToString(); 
                tb_giave.Text = row?.Cells[1]?.Value?.ToString()?.Trim();
                cb_sanbaydi.Text = row?.Cells[2]?.Value?.ToString()?.Trim();
                cb_sanbayden.Text = row?.Cells[3]?.Value?.ToString()?.Trim();
                cb_trunggian.Text = row?.Cells[4]?.Value?.ToString()?.Trim();
                dtp_tgdung.Text = row?.Cells[5]?.Value?.ToString()?.Trim();
                dpt_ngaygio.Text = row?.Cells[6]?.Value?.ToString()?.Trim();
                dtp_tgbay.Text = row?.Cells[7]?.Value?.ToString()?.Trim();
                tb_ghe1.Text = row?.Cells[8]?.Value?.ToString()?.Trim();
                tb_ghe2.Text = row?.Cells[9]?.Value?.ToString()?.Trim();
                rtb_ghichu.Text = row?.Cells[10]?.Value?.ToString()?.Trim();
            }
        }

        //thoát
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //clear text
        private void clearText()
        {
            tb_macb.Clear();
            tb_giave.Clear();
            cb_sanbaydi.SelectedIndex = -1;
            cb_sanbayden.SelectedIndex = -1;
            dpt_ngaygio.ResetText();
            dtp_tgbay.ResetText();
            dtp_tgdung.ResetText();
            cb_trunggian.SelectedIndex = -1;
            tb_ghe1.Clear();
            tb_ghe2.Clear();
            rtb_ghichu.Clear();
        }

        //làm mói
        private void bt_lammoi_Click(object sender, EventArgs e)
        {
            ClearAllErrors(this.Controls);
            clearText();
        }

    
        //nút sửa
        private void bt_sua_Click(object sender, EventArgs e)
        {
            string macb = tb_macb.Text;
            string giave = tb_giave.Text.ToString().Trim();
            string sanbaydi = cb_sanbaydi.Text.ToString().Trim();
            string sanbayden = cb_sanbayden.Text.ToString().Trim();
            string sanbayTG = cb_trunggian.Text.ToString().Trim();
            TimeSpan TGdung = dtp_tgdung.Value.TimeOfDay;
            DateTime ngaygio = dpt_ngaygio.Value;
            TimeSpan TGBay = dtp_tgbay.Value.TimeOfDay;
            string SLGhe1 = tb_ghe1.Text.ToString().Trim();
            string SLGhe2 = tb_ghe2.Text.ToString().Trim();
            string ghichu = rtb_ghichu.Text.ToString().Trim();

            //kiểm tra định dạng số
            bool kt_giave = decimal.TryParse(giave, out decimal kq1);//kiểm tra định dạng giá vé
            bool kt_slghe1 = decimal.TryParse(SLGhe1, out decimal kq2); //kiểm tra định dạng số lượng ghế hạng 1
            bool kt_slghe2 = decimal.TryParse(SLGhe2, out decimal kq3); //kiểm tra định dạng số lượng ghế hạng 2

            //kiểm tra thời gian
            TimeSpan BayToiThieu = new TimeSpan(0, 30, 0); //thời gian bay tối thiểu
            TimeSpan timeDungMin = new TimeSpan(0, 10, 0); //thời gian dừng min
            TimeSpan timeDungMax = new TimeSpan(0, 21, 0); //thời gian dừng max

            try
            {

                //không tìm thấy hay null mã chuyến bay
                if (string.IsNullOrWhiteSpace(macb))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_macb, "Không tìm thấy mã chuyến bay");
                    MessageBox.Show("Lỗi: " + "Không tìm thấy mã chuyến bay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi null giá vé
                else if (string.IsNullOrWhiteSpace(giave))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_giave, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi giá vé không đúng định dạng số, và lỗi < 0
                else if (!kt_giave || kq1 < 0)
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_giave, "Giá vé không hợp lệ");
                    MessageBox.Show("Lỗi: " + "Giá vé không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi null sân bay đi 
                else if (string.IsNullOrWhiteSpace(sanbaydi))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(cb_sanbaydi, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi null sân bay đến
                else if (string.IsNullOrWhiteSpace(sanbayden))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(cb_sanbayden, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi sân bay đến trùng sân bay đi
                else if (sanbayden == sanbaydi)
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(cb_sanbayden, "Sân bay đến không được trùng với sân bay đi");
                    MessageBox.Show("Lỗi: " + "Sân bay đến không được trùng với sân bay đi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // --> điệu kiện đề bài p1: thời gian bay tối thiểu là 30 phút  
                else if (TGBay < BayToiThieu)
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(dtp_tgbay, "Thời gian bay tối thiểu là 30 phút");
                    MessageBox.Show("Lỗi: " + "Thời gian bay tối thiểu là 30 phút", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi null sân bay trung gian
                else if (string.IsNullOrWhiteSpace(sanbayTG))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(cb_trunggian, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // --> Điều kiện đề bài p2: Thời gian dừng trong khoảng 10 -> 20 phút
                else if (TGdung < timeDungMin || TGdung > timeDungMax)
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(dtp_tgdung, "Thời gian dừng chỉ có thể dừng từ 10 đến 20 phút");
                    MessageBox.Show("Lỗi: " + "Thời gian dừng chỉ có thể dừng từ 10 đến 20 phút", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi null số lượng ghế hạng 1
                else if (string.IsNullOrWhiteSpace(SLGhe1))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_ghe1, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi SL ghế hạng 1 không đúng dịnh dạng số và < 0
                else if (!kt_slghe1 || kq2 < 0)
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_ghe1, "Dữ liệu số lượng ghế hạng một nhập không hợp lệ");
                    MessageBox.Show("Lỗi: " + "Dữ liệu số lượng ghế hạng một nhập không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi null số lượng ghế hạng 2
                else if (string.IsNullOrWhiteSpace(SLGhe2))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_ghe2, "Dữ liệu không được để trống");
                    MessageBox.Show("Lỗi: " + "Dữ liệu không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //lỗi SL ghế hạng 2 không đúng dịnh dạng số và < 0
                else if (!kt_slghe2 || kq3 < 0)
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_ghe2, "Dữ liệu số lượng ghế hạng hai nhập không hợp lệ");
                    MessageBox.Show("Lỗi: " + "Dữ liệu số lượng ghế hạng hai nhập không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //thực hiện khi thỏa mãn
                else
                {
                    ClearAllErrors(this.Controls);

                    string query = "UPDATE LICHCHUYENBAY SET GIAVE = @giave, SANBAYDI = @sanbaydi, SANBAYDEN = @sanbayden, SANBAYTRUNGGIAN = @sanbayTG, THOIGIANDUNG = @TGdung," +
                                                              "NGAYGIO = @ngaygio, THOIGIANBAY = @TGbay, SOLUONGGHEHANG1 = @SLGhe1, SOLUONGGHEHANG2 = @SLGhe2, GHICHU = @ghichu" +
                                                              " WHERE MACHUYENBAY LIKE @macb ";
                    using (SQLiteConnection connection = Connection.getConnection())
                    {
                        connection.Open();
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        command.Parameters.AddWithValue("@macb", macb);
                        command.Parameters.AddWithValue("@giave", giave);
                        command.Parameters.AddWithValue("@sanbaydi", sanbaydi);
                        command.Parameters.AddWithValue("@sanbayden", sanbayden);
                        command.Parameters.AddWithValue("@sanbayTG", sanbayTG);
                        command.Parameters.AddWithValue("@TGdung", TGdung);
                        command.Parameters.AddWithValue("@ngaygio", ngaygio);
                        command.Parameters.AddWithValue("@TGbay", TGBay);
                        command.Parameters.AddWithValue("@SLGhe1", SLGhe1);
                        command.Parameters.AddWithValue("@SLGhe2", SLGhe2);
                        command.Parameters.AddWithValue("@ghichu", ghichu);
                        command.ExecuteNonQuery();
                        connection.Close();
                        clearText();
                        MessageBox.Show("Sửa thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienthi();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //nút xóa 
        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string macb = tb_macb.Text.ToString().Trim();

            try
            {
                //lỗi không tìm thấy mã chuyến bay
                if (string.IsNullOrWhiteSpace(macb))
                {
                    ClearAllErrors(this.Controls);
                    errorProvider.SetError(tb_macb, "Không tìm thấy mã chuyến bay");
                    MessageBox.Show("Lỗi: " + "Không tìm thấy mã chuyến bay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //thực hiện lệnh khi thỏa mãn
                else
                {
                    ClearAllErrors(this.Controls);
                    // Hiển thị thông báo xác nhận
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    // Kiểm tra lựa chọn của người dùng
                    if (result == DialogResult.Yes)
                    {
                        // Thực hiện hành động xóa dữ liệu
                        string query = "DELETE FROM LICHCHUYENBAY WHERE MACHUYENBAY = @macb ";
                        using (SQLiteConnection connection = Connection.getConnection())
                        {
                            connection.Open();
                            SQLiteCommand command = new SQLiteCommand(query, connection);
                            command.Parameters.AddWithValue("@macb", macb);
                            command.ExecuteNonQuery();
                            connection.Close();
                            clearText();
                            MessageBox.Show("Xóa thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            hienthi();
                            clearText();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
