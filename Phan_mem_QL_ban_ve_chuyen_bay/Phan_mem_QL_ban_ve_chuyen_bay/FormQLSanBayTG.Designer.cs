namespace Phan_mem_QL_ban_ve_chuyen_bay
{
    partial class FormQLSanBayTG
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_masbTG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_trangthai = new System.Windows.Forms.ComboBox();
            this.bt_lammoi = new Phan_mem_QL_ban_ve_chuyen_bay.Custom.CustomButton.VBButton();
            this.bt_thoat = new Phan_mem_QL_ban_ve_chuyen_bay.Custom.CustomButton.VBButton();
            this.bt_xoa = new Phan_mem_QL_ban_ve_chuyen_bay.Custom.CustomButton.VBButton();
            this.bt_sua = new Phan_mem_QL_ban_ve_chuyen_bay.Custom.CustomButton.VBButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_them = new Phan_mem_QL_ban_ve_chuyen_bay.Custom.CustomButton.VBButton();
            this.tb_tenTG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgr_TG = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_TG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(0, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1035, 275);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tb_masbTG);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_trangthai);
            this.panel1.Controls.Add(this.bt_lammoi);
            this.panel1.Controls.Add(this.bt_thoat);
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_them);
            this.panel1.Controls.Add(this.tb_tenTG);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 248);
            this.panel1.TabIndex = 5;
            // 
            // tb_masbTG
            // 
            this.tb_masbTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_masbTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_masbTG.Location = new System.Drawing.Point(423, 34);
            this.tb_masbTG.Name = "tb_masbTG";
            this.tb_masbTG.Size = new System.Drawing.Size(292, 28);
            this.tb_masbTG.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mã sân bay trung gian";
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_trangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_trangthai.FormattingEnabled = true;
            this.cb_trangthai.Items.AddRange(new object[] {
            "Đang hoạt động",
            "Bảo trì",
            "Dừng hoạt động"});
            this.cb_trangthai.Location = new System.Drawing.Point(425, 134);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(292, 28);
            this.cb_trangthai.TabIndex = 37;
            // 
            // bt_lammoi
            // 
            this.bt_lammoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_lammoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_lammoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_lammoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_lammoi.BorderRadius = 3;
            this.bt_lammoi.BorderSize = 0;
            this.bt_lammoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_lammoi.FlatAppearance.BorderSize = 0;
            this.bt_lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_lammoi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lammoi.ForeColor = System.Drawing.Color.White;
            this.bt_lammoi.Location = new System.Drawing.Point(425, 200);
            this.bt_lammoi.Name = "bt_lammoi";
            this.bt_lammoi.Size = new System.Drawing.Size(116, 40);
            this.bt_lammoi.TabIndex = 8;
            this.bt_lammoi.Text = "LÀM MỚI";
            this.bt_lammoi.TextColor = System.Drawing.Color.White;
            this.bt_lammoi.UseVisualStyleBackColor = false;
            this.bt_lammoi.Click += new System.EventHandler(this.bt_lammoi_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_thoat.BackColor = System.Drawing.Color.Red;
            this.bt_thoat.BackgroundColor = System.Drawing.Color.Red;
            this.bt_thoat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_thoat.BorderRadius = 3;
            this.bt_thoat.BorderSize = 0;
            this.bt_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_thoat.FlatAppearance.BorderSize = 0;
            this.bt_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.ForeColor = System.Drawing.Color.White;
            this.bt_thoat.Location = new System.Drawing.Point(3, 206);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(88, 39);
            this.bt_thoat.TabIndex = 7;
            this.bt_thoat.Text = "THOÁT";
            this.bt_thoat.TextColor = System.Drawing.Color.White;
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_xoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_xoa.BorderRadius = 3;
            this.bt_xoa.BorderSize = 0;
            this.bt_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_xoa.FlatAppearance.BorderSize = 0;
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.White;
            this.bt_xoa.Location = new System.Drawing.Point(795, 172);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(116, 40);
            this.bt_xoa.TabIndex = 6;
            this.bt_xoa.Text = "XÓA";
            this.bt_xoa.TextColor = System.Drawing.Color.White;
            this.bt_xoa.UseVisualStyleBackColor = false;
            // 
            // bt_sua
            // 
            this.bt_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_sua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_sua.BorderRadius = 3;
            this.bt_sua.BorderSize = 0;
            this.bt_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sua.FlatAppearance.BorderSize = 0;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.Color.White;
            this.bt_sua.Location = new System.Drawing.Point(795, 99);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(116, 40);
            this.bt_sua.TabIndex = 5;
            this.bt_sua.Text = "SỬA";
            this.bt_sua.TextColor = System.Drawing.Color.White;
            this.bt_sua.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng thái";
            // 
            // bt_them
            // 
            this.bt_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_them.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bt_them.BorderRadius = 3;
            this.bt_them.BorderSize = 0;
            this.bt_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_them.FlatAppearance.BorderSize = 0;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.White;
            this.bt_them.Location = new System.Drawing.Point(795, 35);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(116, 40);
            this.bt_them.TabIndex = 4;
            this.bt_them.Text = "THÊM";
            this.bt_them.TextColor = System.Drawing.Color.White;
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // tb_tenTG
            // 
            this.tb_tenTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_tenTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenTG.Location = new System.Drawing.Point(425, 83);
            this.tb_tenTG.Name = "tb_tenTG";
            this.tb_tenTG.Size = new System.Drawing.Size(292, 28);
            this.tb_tenTG.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sân bay trung gian";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.dgr_TG);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1035, 380);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách các sân bay trung gian";
            // 
            // dgr_TG
            // 
            this.dgr_TG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgr_TG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_TG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_TG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgr_TG.Location = new System.Drawing.Point(21, 23);
            this.dgr_TG.Name = "dgr_TG";
            this.dgr_TG.ReadOnly = true;
            this.dgr_TG.RowHeadersWidth = 51;
            this.dgr_TG.RowTemplate.Height = 24;
            this.dgr_TG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_TG.Size = new System.Drawing.Size(994, 351);
            this.dgr_TG.TabIndex = 0;
            this.dgr_TG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_TG_CellContentClick);
            // 
            // FormQLSanBayTG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQLSanBayTG";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SÂN BAY TRUNG GIAN";
            this.Load += new System.EventHandler(this.FormQLSanBayTG_Load);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgr_TG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private Custom.CustomButton.VBButton bt_lammoi;
        private Custom.CustomButton.VBButton bt_thoat;
        private Custom.CustomButton.VBButton bt_xoa;
        private Custom.CustomButton.VBButton bt_sua;
        private System.Windows.Forms.Label label1;
        private Custom.CustomButton.VBButton bt_them;
        private System.Windows.Forms.TextBox tb_tenTG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgr_TG;
        private System.Windows.Forms.ComboBox cb_trangthai;
        private System.Windows.Forms.TextBox tb_masbTG;
        private System.Windows.Forms.Label label3;
    }
}