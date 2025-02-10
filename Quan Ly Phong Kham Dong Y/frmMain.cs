using Quan_Ly_Phong_Kham_Dong_Y.Class;
using System.Data;

namespace Quan_Ly_Phong_Kham_Dong_Y
{
    public partial class frmMain : Form
    {
        DataTable tblBN;
        private string maNV;
        public frmMain(string taiKhoan)
        {
            InitializeComponent();
            maNV = taiKhoan;
            lblMaNV.Text = @"Mã Nhân Viên: " + taiKhoan + "";
        }

        private void lblMaNV_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDataGridView();

        }
        private void LoadDataGridView()
        {
            String sql;
            sql = "SELECT * FROM BenhNhan";
            tblBN = Functions.GetDataToTable(sql);
            dgvBN.DataSource = tblBN;
            dgvBN.Columns[0].HeaderText = "Mã bệnh nhân";
            dgvBN.Columns[1].HeaderText = "Họ và tên";
            dgvBN.Columns[2].HeaderText = "Giới tính";
            dgvBN.Columns[3].HeaderText = "Ngày sinh";
            dgvBN.Columns[4].HeaderText = "Địa chỉ";
            dgvBN.Columns[5].HeaderText = "Điện thoại";
            dgvBN.Columns[6].HeaderText = "Mã nhân viên";

        }

        private void dgvBN_Click(object sender, EventArgs e)
        {
            if (btnThemBN.Enabled == false)
            {

            }
            txtMaBN.Text = dgvBN.CurrentRow.Cells["maBN"].Value.ToString();
            txtTenBN.Text = dgvBN.CurrentRow.Cells["hoTenBN"].Value.ToString();
            txtDiaChi.Text = dgvBN.CurrentRow.Cells["diaChi"].Value.ToString();
            mskDienThoai.Text = dgvBN.CurrentRow.Cells["dienThoai"].Value.ToString();
            if (dgvBN.CurrentRow.Cells["gioiTinh"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
                radNu.Checked = false;
            }
            else
            {
                radNu.Checked = true;
                radNam.Checked = false;
            }
            dateTimePickerNgaySinh.Value = (DateTime)dgvBN.CurrentRow.Cells["ngaySinh"].Value;
        }
        private void ResetValues()
        {
            txtTenBN.Clear();
            txtDiaChi.Clear();
            txtMaBN.Clear();
            mskDienThoai.Clear();
            dateTimePickerNgaySinh.Value = DateTime.Now;
        }
        private void btnThemBN_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtTenBN.Focus();
            string sql;
            sql = "SELECT maBN FROM BenhNhan WHERE maBN=N'" + txtMaBN.Text.Trim() + "'";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (radNam.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nu";
            }
            sql = "INSERT INTO BenhNhan (maBN,hoTenBN,gioiTinh,ngaySinh,diaChi,dienThoai,maNV) VALUES (N'" + txtMaBN.Text.Trim() + "',N'" + txtTenBN.Text.Trim() + "','" + gt + "','" + dateTimePickerNgaySinh.Value + "',N'" + txtDiaChi.Text.Trim() + "','" + mskDienThoai.Text + "','" + maNV + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnSuaBN_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblBN.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn bệnh nhân để sửa");
                return;
            }
            if (radNam.Checked == true)
            {
                gt = "Nam";
            }
            else
            {
                gt = "Nu";
            }
            sql = "UPDATE BenhNhan SET hoTenBN=N'" + txtTenBN.Text.Trim() + "', gioiTinh='" + gt + "', ngaySinh='" + dateTimePickerNgaySinh.Value + "', diaChi=N'" + txtDiaChi.Text.Trim() + "', dienThoai='" + mskDienThoai.Text + "' WHERE maBN='" + txtMaBN.Text.Trim() + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnXoaBN_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblBN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
                return;
            }
            if (txtMaBN.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bệnh nhân nào");
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE BenhNhan WHERE maBN='" + txtMaBN.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
        private void UpdateMaBN()
        {
            string gioiTinh = radNam.Checked ? "1" : "0";
            string ngaySinh = dateTimePickerNgaySinh.Value.ToString("yyyy");
            string tenBN = txtTenBN.Text.Trim();
            string[] tenParts = tenBN.Split(' ');
            string tenCode = tenParts.Length > 0 ? tenParts.Last().ToUpper() : "";
            txtMaBN.Text = $"BN{gioiTinh}{ngaySinh}{tenCode}";
        }

        private void Update(object sender, EventArgs e)
        {
            UpdateMaBN();
        }
    }
}
