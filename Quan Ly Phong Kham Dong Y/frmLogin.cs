using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Quan_Ly_Phong_Kham_Dong_Y.Class;

namespace Quan_Ly_Phong_Kham_Dong_Y
{
    public partial class frmLogin : Form
    {
        public string maNV { get; private set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lbTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan=txtTaiKhoan.Text;
            string matKhau=txtMatKhau.Text;
            if (txtTaiKhoan.Text.Length == 0 && txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Tài Khoản hoặc mật khẩu sai");
            }
            else if (txtTaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Tài Khoản hoặc mật khẩu sai");
            }
            else if (txtMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Tài Khoản hoặc mật khẩu sai");
            }
            else
            {
                Functions.Connect();
                string sql = "SELECT maNV, matKhau FROM NhanVien WHERE maNV='"+taiKhoan+"' AND matKhau='"+matKhau+"'";
                if (Functions.GetDataToTable(sql).Rows.Count==0)
                {
                    MessageBox.Show("Tài Khoản hoặc mật khẩu sai");
                }
                else
                {
                    maNV = taiKhoan;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
