namespace Phan_mem_QL_ban_ve_chuyen_bay
{
    partial class FormQuanLyTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyTaiKhoan));
            this.tb_tk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgr_taikhoan = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_mk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_dc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.dtp_ns = new System.Windows.Forms.DateTimePicker();
            this.cb_gt = new System.Windows.Forms.ComboBox();
            this.cb_cv = new System.Windows.Forms.ComboBox();
            this.bt_them = new Phan_mem_QL_ban_ve_chuyen_bay.Custom.CustomButton.VBButton();
            this.bt_sua = new Phan_mem_QL_ban_ve_chuyen_bay.Custom.CustomButton.VBButton();
            this.bt_xoa = new Phan_mem_QL_ban_ve_chuyen_bay.Custom.CustomButton.VBButton();
            this.bt_timkiem = new Phan_mem_QL_ban_ve_chuyen_bay.Custom.CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_taikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_tk
            // 
            this.tb_tk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tk.Location = new System.Drawing.Point(205, 417);
            this.tb_tk.Name = "tb_tk";
            this.tb_tk.Size = new System.Drawing.Size(341, 30);
            this.tb_tk.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản:";
            // 
            // dgr_taikhoan
            // 
            this.dgr_taikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_taikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_taikhoan.Location = new System.Drawing.Point(77, 1);
            this.dgr_taikhoan.Name = "dgr_taikhoan";
            this.dgr_taikhoan.ReadOnly = true;
            this.dgr_taikhoan.RowHeadersWidth = 51;
            this.dgr_taikhoan.RowTemplate.Height = 24;
            this.dgr_taikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_taikhoan.Size = new System.Drawing.Size(1410, 361);
            this.dgr_taikhoan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu:";
            // 
            // tb_mk
            // 
            this.tb_mk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mk.Location = new System.Drawing.Point(205, 473);
            this.tb_mk.Name = "tb_mk";
            this.tb_mk.Size = new System.Drawing.Size(341, 30);
            this.tb_mk.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Họ và tên:";
            // 
            // tb_hoten
            // 
            this.tb_hoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hoten.Location = new System.Drawing.Point(205, 525);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(341, 30);
            this.tb_hoten.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 640);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 694);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Địa chỉ:";
            // 
            // tb_dc
            // 
            this.tb_dc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dc.Location = new System.Drawing.Point(205, 691);
            this.tb_dc.Name = "tb_dc";
            this.tb_dc.Size = new System.Drawing.Size(341, 30);
            this.tb_dc.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(702, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số điện thoại:";
            // 
            // tb_sdt
            // 
            this.tb_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdt.Location = new System.Drawing.Point(863, 417);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(341, 30);
            this.tb_sdt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(702, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Chức vụ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(702, 528);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Email:";
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(863, 523);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(341, 30);
            this.tb_email.TabIndex = 18;
            // 
            // dtp_ns
            // 
            this.dtp_ns.CustomFormat = "dd/MM/yyyy";
            this.dtp_ns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ns.Location = new System.Drawing.Point(205, 580);
            this.dtp_ns.Name = "dtp_ns";
            this.dtp_ns.Size = new System.Drawing.Size(341, 30);
            this.dtp_ns.TabIndex = 23;
            // 
            // cb_gt
            // 
            this.cb_gt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_gt.FormattingEnabled = true;
            this.cb_gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gt.Location = new System.Drawing.Point(205, 632);
            this.cb_gt.Name = "cb_gt";
            this.cb_gt.Size = new System.Drawing.Size(341, 33);
            this.cb_gt.TabIndex = 24;
            // 
            // cb_cv
            // 
            this.cb_cv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cv.FormattingEnabled = true;
            this.cb_cv.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản trị"});
            this.cb_cv.Location = new System.Drawing.Point(863, 465);
            this.cb_cv.Name = "cb_cv";
            this.cb_cv.Size = new System.Drawing.Size(341, 33);
            this.cb_cv.TabIndex = 25;
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_them.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_them.BorderColor = System.Drawing.Color.Cyan;
            this.bt_them.BorderRadius = 13;
            this.bt_them.BorderSize = 2;
            this.bt_them.FlatAppearance.BorderSize = 0;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.White;
            this.bt_them.Location = new System.Drawing.Point(1299, 397);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(151, 50);
            this.bt_them.TabIndex = 26;
            this.bt_them.Text = "THÊM";
            this.bt_them.TextColor = System.Drawing.Color.White;
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_sua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_sua.BorderColor = System.Drawing.Color.Cyan;
            this.bt_sua.BorderRadius = 13;
            this.bt_sua.BorderSize = 2;
            this.bt_sua.FlatAppearance.BorderSize = 0;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.Color.White;
            this.bt_sua.Location = new System.Drawing.Point(1299, 474);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(151, 50);
            this.bt_sua.TabIndex = 27;
            this.bt_sua.Text = "SỬA";
            this.bt_sua.TextColor = System.Drawing.Color.White;
            this.bt_sua.UseVisualStyleBackColor = false;
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.Red;
            this.bt_xoa.BackgroundColor = System.Drawing.Color.Red;
            this.bt_xoa.BorderColor = System.Drawing.Color.Cyan;
            this.bt_xoa.BorderRadius = 13;
            this.bt_xoa.BorderSize = 2;
            this.bt_xoa.FlatAppearance.BorderSize = 0;
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.White;
            this.bt_xoa.Location = new System.Drawing.Point(1299, 557);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(151, 50);
            this.bt_xoa.TabIndex = 28;
            this.bt_xoa.Text = "XÓA";
            this.bt_xoa.TextColor = System.Drawing.Color.White;
            this.bt_xoa.UseVisualStyleBackColor = false;
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_timkiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bt_timkiem.BorderColor = System.Drawing.Color.Cyan;
            this.bt_timkiem.BorderRadius = 13;
            this.bt_timkiem.BorderSize = 2;
            this.bt_timkiem.FlatAppearance.BorderSize = 0;
            this.bt_timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.ForeColor = System.Drawing.Color.White;
            this.bt_timkiem.Location = new System.Drawing.Point(1299, 633);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(151, 50);
            this.bt_timkiem.TabIndex = 29;
            this.bt_timkiem.Text = "TÌM KIẾM";
            this.bt_timkiem.TextColor = System.Drawing.Color.White;
            this.bt_timkiem.UseVisualStyleBackColor = false;
            // 
            // FormQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 790);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.cb_cv);
            this.Controls.Add(this.cb_gt);
            this.Controls.Add(this.dtp_ns);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_sdt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_dc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_hoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_mk);
            this.Controls.Add(this.dgr_taikhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.FormQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_taikhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_tk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgr_taikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_mk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_dc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.DateTimePicker dtp_ns;
        private System.Windows.Forms.ComboBox cb_gt;
        private System.Windows.Forms.ComboBox cb_cv;
        private Custom.CustomButton.VBButton bt_them;
        private Custom.CustomButton.VBButton bt_sua;
        private Custom.CustomButton.VBButton bt_xoa;
        private Custom.CustomButton.VBButton bt_timkiem;
    }
}