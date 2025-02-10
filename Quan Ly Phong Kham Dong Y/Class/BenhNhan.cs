using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Quan_Ly_Phong_Kham_Dong_Y.Class;

namespace Quan_Ly_Phong_Kham_Dong_Y.Class
{
    class BenhNhan
    {
        private string _maBN;
        private string _tenBN;
        private string _gioiTinh;
        private string _diaChi;
        private DateFormat _ngaySinh;
        private int _dienThoai;
        private string maNV;

        public BenhNhan() { }

        public BenhNhan(string maBN, string tenBN, string gioiTinh, string diaChi, DateFormat ngaySinh, int dienThoai, string maNV)
        {
            _maBN = maBN;
            _tenBN = tenBN;
            _gioiTinh = gioiTinh;
            _diaChi = diaChi;
            _ngaySinh = ngaySinh;
            _dienThoai = dienThoai;
            this.maNV = maNV;
        }

        public string MaBN { get => _maBN; set => _maBN = value; }
        public string TenBN { get => _tenBN; set => _tenBN = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public DateFormat NgaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public int DienThoai { get => _dienThoai; set => _dienThoai = value; }
        public string MaNV { get => maNV; set => maNV = value; }
    }
}
