using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    
    public partial class Form1 : Form
    {
        private List<CNhanVien> lstNV;
        public Form1()
        {
            InitializeComponent();
            loadListView();
            getDSNV();
            hienThi();
        }

        public void loadListView()
        {
            listView1.Columns.Add("Msnv");
            listView1.Columns.Add("Họ tênn");
            listView1.Columns.Add("Ngày vào làm");
            listView1.Columns.Add("Lương");
        
        }

        public void hienThi()
        {
            listView1.Items.Clear();
            foreach(CNhanVien nv in lstNV)
            {
                ListViewItem lvi = new ListViewItem(nv.Msnv);

                lvi.SubItems.Add(nv.Hoten);
                lvi.SubItems.Add(nv.Ngayvaolam.ToShortDateString());
                lvi.SubItems.Add(nv.getLuong()+"");
                listView1.Items.Add(lvi);
            }
        }

        private void getDSNV()
        {
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            lstNV = new List<CNhanVien>();
            CNhanVien nv1 = new CNhanVien("NV01", "Gao đỏ", DateTime.Now, 1000000, 5);
            lstNV.Add(nv1);
           
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMSNV.Text;
            string ten = txtHoTen.Text;
            DateTime dt = date.Value;
            double luongcb = double.Parse(txtLuongCB.Text);
            double heso = double.Parse(txtHeSo.Text);

            CNhanVien nv = new CNhanVien(ma, ten, dt, luongcb, heso);
            lstNV.Add(nv);
            hienThi();
        }
    }
}
