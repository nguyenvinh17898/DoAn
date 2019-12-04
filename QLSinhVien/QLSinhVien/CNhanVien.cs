using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSinhVien
{
    class CNhanVien
    {
        private string msnv;
        private string hoten;
        private DateTime ngayvaolam;
        private double luongcb;
        private double heso;

        public string Msnv
        {
            get { return msnv; }
            set { msnv = value; }
        }
        

        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        

        public DateTime Ngayvaolam
        {
            get { return ngayvaolam; }
            set { ngayvaolam = value; }
        }
        

        public double Luongcb
        {
            get { return luongcb; }
            set { luongcb = value; }
        }
        

        public double Heso
        {
            get { return heso; }
            set { heso = value; }
        }

        public CNhanVien()
        {
            msnv = "";
            hoten = "";
            ngayvaolam = DateTime.Now;
            luongcb = 0;
            heso = 0;
        }

        public CNhanVien(string manv, string tennv, DateTime ngay, double luongcoban, double hs)
        {
            msnv = manv;
            hoten = tennv;
            ngayvaolam = ngay;
            luongcb = luongcoban;
            heso = hs;
        }

        public double getLuong()
        {
            return luongcb * heso;
        }

    }
}
