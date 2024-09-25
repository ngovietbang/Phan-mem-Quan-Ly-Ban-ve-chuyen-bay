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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            //tạm ẩn panel báo cáo
            p_an.Visible = false;
            p_an.Enabled = false;
            //tạm ẩn panel hệ thống
            panel_ht.Visible = false;   
            panel_ht.Enabled = false;
            //tạm ẩn panel tài khoản
            panel_an2.Visible = false;
            panel_an2.Enabled = false;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }


        //vùng hiệu ứng
        #region hieuung1 
        //nút báo cáo
        private void bt_baocao_Click(object sender, EventArgs e)
        {
            //bật panel báo cáo
            p_an.Visible = !p_an.Visible;
            p_an.Enabled = !p_an.Enabled;

        }
        //
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            // Nếu Panel đang hiển thị và nhấn chuột bên ngoài Panel, thì ẩn Panel
            if (p_an.Visible && !p_an.Bounds.Contains(e.Location))
            {
                p_an.Visible = false;
            }
            if (panel_ht.Visible && !panel_ht.Bounds.Contains(e.Location))
            {
                panel_ht.Visible = false;
            }
            if (panel_an2.Visible && !panel_an2.Bounds.Contains(e.Location))
            {
                panel_an2.Visible = false;
            }
        }
        //nút hệ thống
        private void bt_hethong_Click(object sender, EventArgs e)
        {
            //bật panel hệ thống
            panel_ht.Visible = !panel_ht.Visible;
            panel_ht.Enabled = !panel_ht.Enabled;
        }
        #endregion


        //Vùng menu
        #region menu
        //nút nhận lịch
        private void bt_nhanlich_Click(object sender, EventArgs e)
        {
            FormNhanLichChuyenBay f = new FormNhanLichChuyenBay();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion


        //vùng hệ thống
        #region hethong
        //nút sân bay -> hiển thị form Quản lý các sân bay
        private void bt_sanbay_Click(object sender, EventArgs e)
        {
            FormQLCacSanBay f = new FormQLCacSanBay();  
            this.Enabled=false;
            f.ShowDialog();
            this.Enabled=true;
        }

        //sân bay trung gian
        private void bt_sbtrunggian_Click(object sender, EventArgs e)
        {
            FormQLSanBayTG f = new FormQLSanBayTG();    
            this.Enabled=false;
            f.ShowDialog();
            this.Enabled=true;
        }

        #endregion

        //cùng tài khoản
        #region taikhoan
        // nút tài khoản chính
        private void bt_taikhoan_Click(object sender, EventArgs e)
        {
            //bật panel hệ thống
            panel_an2.Visible = !panel_an2.Visible;
            panel_an2.Enabled = !panel_an2.Enabled;
        }

        //nút quản lý tài khoản admin
        private void bt_qltkadmin_Click(object sender, EventArgs e)
        {
            FormQuanLyTaiKhoan f = new FormQuanLyTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        //nút quản lý tài khoản người dùng
        private void bt_qltk_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
