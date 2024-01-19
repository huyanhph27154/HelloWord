using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_lapTrinhHuongDoiTuong
{
    internal class SanPham
    {
        public int MaSanPham {  get; set; }
        public string TenSanPham { get; set; }
        public int DonGia {  get; set; }
        public int SoLuong {  get; set; }

        public SanPham()
        {
            
        }

        public SanPham(int maSanPham, string tenSanPham, int donGia, int soLuong)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            DonGia = donGia;
            SoLuong = soLuong;
        }
    }
}
