namespace Quan_Ly_Phong_Kham_Dong_Y
{
    partial class frmMain
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
            panel1 = new Panel();
            groupboxBN = new GroupBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            dateTimePickerNgaySinh = new DateTimePicker();
            mskDienThoai = new MaskedTextBox();
            txtDiaChi = new TextBox();
            txtTenBN = new TextBox();
            txtMaBN = new TextBox();
            lblDienThoai = new Label();
            lblDiaChi = new Label();
            lblNgaySinh = new Label();
            lblGioiTinh = new Label();
            lblTenBN = new Label();
            lblMaBN = new Label();
            lblMaNV = new Label();
            panel2 = new Panel();
            btnDangXuat = new Button();
            btnLuu = new Button();
            btnXoaBN = new Button();
            btnSuaBN = new Button();
            btnThemBN = new Button();
            dgvBN = new DataGridView();
            panel1.SuspendLayout();
            groupboxBN.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBN).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupboxBN);
            panel1.Controls.Add(lblMaNV);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 244);
            panel1.TabIndex = 0;
            // 
            // groupboxBN
            // 
            groupboxBN.Controls.Add(radNu);
            groupboxBN.Controls.Add(radNam);
            groupboxBN.Controls.Add(dateTimePickerNgaySinh);
            groupboxBN.Controls.Add(mskDienThoai);
            groupboxBN.Controls.Add(txtDiaChi);
            groupboxBN.Controls.Add(txtTenBN);
            groupboxBN.Controls.Add(txtMaBN);
            groupboxBN.Controls.Add(lblDienThoai);
            groupboxBN.Controls.Add(lblDiaChi);
            groupboxBN.Controls.Add(lblNgaySinh);
            groupboxBN.Controls.Add(lblGioiTinh);
            groupboxBN.Controls.Add(lblTenBN);
            groupboxBN.Controls.Add(lblMaBN);
            groupboxBN.Location = new Point(12, 44);
            groupboxBN.Name = "groupboxBN";
            groupboxBN.Size = new Size(1060, 180);
            groupboxBN.TabIndex = 0;
            groupboxBN.TabStop = false;
            groupboxBN.Text = "Thông tin bệnh nhân";
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(298, 146);
            radNu.Name = "radNu";
            radNu.Size = new Size(41, 19);
            radNu.TabIndex = 15;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            radNu.CheckedChanged += Update;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Checked = true;
            radNam.Location = new Point(188, 146);
            radNam.Name = "radNam";
            radNam.Size = new Size(51, 19);
            radNam.TabIndex = 14;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            radNam.CheckedChanged += Update;
            // 
            // dateTimePickerNgaySinh
            // 
            dateTimePickerNgaySinh.Location = new Point(577, 48);
            dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            dateTimePickerNgaySinh.Size = new Size(246, 23);
            dateTimePickerNgaySinh.TabIndex = 11;
            dateTimePickerNgaySinh.ValueChanged += Update;
            // 
            // mskDienThoai
            // 
            mskDienThoai.Location = new Point(577, 144);
            mskDienThoai.Name = "mskDienThoai";
            mskDienThoai.Size = new Size(246, 23);
            mskDienThoai.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(577, 97);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(246, 23);
            txtDiaChi.TabIndex = 9;
            // 
            // txtTenBN
            // 
            txtTenBN.Location = new Point(188, 97);
            txtTenBN.Name = "txtTenBN";
            txtTenBN.Size = new Size(246, 23);
            txtTenBN.TabIndex = 8;
            txtTenBN.TextChanged += Update;
            // 
            // txtMaBN
            // 
            txtMaBN.Enabled = false;
            txtMaBN.Location = new Point(188, 48);
            txtMaBN.Name = "txtMaBN";
            txtMaBN.Size = new Size(246, 23);
            txtMaBN.TabIndex = 7;
            // 
            // lblDienThoai
            // 
            lblDienThoai.Location = new Point(479, 142);
            lblDienThoai.Name = "lblDienThoai";
            lblDienThoai.Size = new Size(100, 23);
            lblDienThoai.TabIndex = 5;
            lblDienThoai.Text = "Điện Thoại";
            lblDienThoai.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Location = new Point(479, 95);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(100, 23);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa Chỉ";
            lblDiaChi.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Location = new Point(479, 48);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(100, 23);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày Sinh";
            lblNgaySinh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Location = new Point(57, 144);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(100, 23);
            lblGioiTinh.TabIndex = 2;
            lblGioiTinh.Text = "Giới Tính";
            lblGioiTinh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTenBN
            // 
            lblTenBN.Location = new Point(57, 96);
            lblTenBN.Name = "lblTenBN";
            lblTenBN.Size = new Size(100, 23);
            lblTenBN.TabIndex = 1;
            lblTenBN.Text = "Họ và tên";
            lblTenBN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMaBN
            // 
            lblMaBN.Location = new Point(57, 48);
            lblMaBN.Name = "lblMaBN";
            lblMaBN.Size = new Size(100, 23);
            lblMaBN.TabIndex = 0;
            lblMaBN.Text = "Mã Bệnh Nhân";
            lblMaBN.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMaNV
            // 
            lblMaNV.Location = new Point(12, 9);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(225, 23);
            lblMaNV.TabIndex = 6;
            lblMaNV.Text = "Mã Nhân Viên: ";
            lblMaNV.TextAlign = ContentAlignment.MiddleLeft;
            lblMaNV.Click += frmMain_Load;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDangXuat);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnXoaBN);
            panel2.Controls.Add(btnSuaBN);
            panel2.Controls.Add(btnThemBN);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 498);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 100);
            panel2.TabIndex = 1;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(995, 35);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(77, 30);
            btnDangXuat.TabIndex = 4;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(520, 35);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(101, 30);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaBN
            // 
            btnXoaBN.Location = new Point(374, 35);
            btnXoaBN.Name = "btnXoaBN";
            btnXoaBN.Size = new Size(101, 30);
            btnXoaBN.TabIndex = 2;
            btnXoaBN.Text = "Xoa";
            btnXoaBN.UseVisualStyleBackColor = true;
            btnXoaBN.Click += btnXoaBN_Click;
            // 
            // btnSuaBN
            // 
            btnSuaBN.Location = new Point(228, 35);
            btnSuaBN.Name = "btnSuaBN";
            btnSuaBN.Size = new Size(101, 30);
            btnSuaBN.TabIndex = 1;
            btnSuaBN.Text = "Sửa";
            btnSuaBN.UseVisualStyleBackColor = true;
            btnSuaBN.Click += btnSuaBN_Click;
            // 
            // btnThemBN
            // 
            btnThemBN.Location = new Point(82, 35);
            btnThemBN.Name = "btnThemBN";
            btnThemBN.Size = new Size(101, 30);
            btnThemBN.TabIndex = 0;
            btnThemBN.Text = "Thêm";
            btnThemBN.UseVisualStyleBackColor = true;
            btnThemBN.Click += btnThemBN_Click;
            // 
            // dgvBN
            // 
            dgvBN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBN.Dock = DockStyle.Fill;
            dgvBN.Location = new Point(0, 244);
            dgvBN.Name = "dgvBN";
            dgvBN.Size = new Size(1084, 254);
            dgvBN.TabIndex = 2;
            dgvBN.Click += dgvBN_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 598);
            Controls.Add(dgvBN);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMain";
            Text = "Phòng Khám Đông Y Cổ Truyền Long Chi";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            groupboxBN.ResumeLayout(false);
            groupboxBN.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupboxBN;
        private Label lblDienThoai;
        private Label lblDiaChi;
        private Label lblNgaySinh;
        private Label lblGioiTinh;
        private Label lblTenBN;
        private Label lblMaBN;
        private Panel panel2;
        private DataGridView dgvBN;
        private DateTimePicker dateTimePickerNgaySinh;
        private MaskedTextBox mskDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTenBN;
        private TextBox txtMaBN;
        private Button btnSuaBN;
        private Button btnThemBN;
        private Button btnXoaBN;
        private Button btnLuu;
        private Button btnDangXuat;
        private Label lblMaNV;
        private RadioButton radNu;
        private RadioButton radNam;
    }
}