using EFTrucTuyen.Bus;
using EFTrucTuyen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTrucTuyen
{
    public partial class Form1 : Form
    {
        Bus_SanPham busSP;
        public Form1()
        {
            InitializeComponent();
            busSP = new Bus_SanPham();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            busSP.HienThiDSlenCb(cbLoaisp);
            HienThiLenDG();
        }
        void HienThiLenDG()
        {
            dtgvData.DataSource = null;
           busSP.HienThiDSlenCb(dtgvData);
            dtgvData.Columns[0].Width = (int)(dtgvData.Width * 0.22);
            dtgvData.Columns[0].Width = (int)(dtgvData.Width * 0.24);
            dtgvData.Columns[0].Width = (int)(dtgvData.Width * 0.24);
            dtgvData.Columns[0].Width = (int)(dtgvData.Width * 0.24);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = txtTensp.Text;
            p.Price = decimal.Parse(txtDongia.Text);
            p.CategoryID = int.Parse(cbLoaisp.SelectedValue.ToString());
            busSP.ThemSP(p);
            HienThiLenDG();
            txtTensp.Text = txtMasp.Text = txtDongia.Text = "";
            cbLoaisp.SelectedIndex = 0;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductId = int.Parse(txtMasp.Text);
            busSP.XoaSP(p);
            HienThiLenDG();
            txtTensp.Text = txtMasp.Text = txtDongia.Text = "";
            cbLoaisp.SelectedIndex = 0;
        }

        private void dtgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasp.Text = dtgvData.Rows[e.RowIndex].Cells["ProductId"].Value.ToString();
            txtTensp.Text = dtgvData.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
            txtDongia.Text = dtgvData.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            cbLoaisp.Text = dtgvData.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductId = int.Parse(txtMasp.Text);
            p.ProductName = txtTensp.Text;
            p.Price  =decimal.Parse(txtDongia.Text);
            p.CategoryID = int.Parse(cbLoaisp.SelectedValue.ToString());
            busSP.SuaSP(p);
            HienThiLenDG();
            txtTensp.Text = txtMasp.Text = txtDongia.Text = "";
            cbLoaisp.SelectedIndex = 0;

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
