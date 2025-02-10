namespace Quan_Ly_Phong_Kham_Dong_Y
{
    partial class frmLogin
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
            label1 = new Label();
            lbTaiKhoan = new Label();
            lbMatKhau = new Label();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(688, 59);
            label1.TabIndex = 0;
            label1.Text = "Phòng Khám Đông Y Long Chi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTaiKhoan
            // 
            lbTaiKhoan.Location = new Point(85, 134);
            lbTaiKhoan.Name = "lbTaiKhoan";
            lbTaiKhoan.Size = new Size(100, 23);
            lbTaiKhoan.TabIndex = 0;
            lbTaiKhoan.Text = "Mã Nhân Viên";
            lbTaiKhoan.TextAlign = ContentAlignment.MiddleCenter;
            lbTaiKhoan.UseCompatibleTextRendering = true;
            lbTaiKhoan.Click += lbTaiKhoan_Click;
            // 
            // lbMatKhau
            // 
            lbMatKhau.Location = new Point(85, 201);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(100, 23);
            lbMatKhau.TabIndex = 0;
            lbMatKhau.Text = "Mật Khẩu";
            lbMatKhau.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(240, 201);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(310, 23);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(240, 134);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(310, 23);
            txtTaiKhoan.TabIndex = 0;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(279, 281);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(106, 32);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // frmLogin
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 346);
            Controls.Add(btnDangNhap);
            Controls.Add(txtTaiKhoan);
            Controls.Add(txtMatKhau);
            Controls.Add(lbMatKhau);
            Controls.Add(lbTaiKhoan);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phòng Khám Đông Y Cổ Truyền Long Chi";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbTaiKhoan;
        private Label lbMatKhau;
        private TextBox txtMatKhau;
        private TextBox txtTaiKhoan;
        private Button btnDangNhap;
    }
}