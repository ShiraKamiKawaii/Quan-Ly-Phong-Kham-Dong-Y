using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quan_Ly_Phong_Kham_Dong_Y.Class
{
    class Functions
    {
        public static SqlConnection con;
        //Tạo phương thức Connection
        public static void Connect()
        {
            con = new SqlConnection(); //Khởi tạo đối tượng
            con.ConnectionString = Properties.Settings.Default.QLPhongKhamDongYConnectionString;
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            else
            {
                MessageBox.Show("Kết nối không thành công");
            }
        }
        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }
        public static DataTable GetDataToTable(String sql)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(table);
            return table;
        }
        //Thực thi Insert, Update, Delete
        public static void RunSQL(String sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();//thực thi sql
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }
        //hàm check Mã trùng
        
    }
}
