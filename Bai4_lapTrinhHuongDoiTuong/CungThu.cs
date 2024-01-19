using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_lapTrinhHuongDoiTuong
{
    public class CungThu
    {
        public int DiemTanCong { get; set; }
        public int DiemPhongThu { get; set; }
        public int HP { get; set; }
        public int TocDo { get; set; }

        public CungThu()
        {
            
        }

        public void KyNang1()
        {
            this.DiemTanCong *= 2;
        }
    }
}
