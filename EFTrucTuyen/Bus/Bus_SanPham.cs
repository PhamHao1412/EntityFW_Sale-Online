using EFTrucTuyen.DAO;
using EFTrucTuyen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTrucTuyen.Bus
{
    internal class Bus_SanPham
    {
        DAO_SanPham dSP;
        public Bus_SanPham()
        {
            dSP = new DAO_SanPham();
        }
        public void HienThiDSlenCb(ComboBox cb)
        {
            cb.DataSource  = dSP.LayDSLoaiSP();
            cb.DisplayMember = "CategoryName";
            cb.ValueMember = "CategoryId";
        }
        public void HienThiDSlenCb(DataGridView dg)
        {
            dg.DataSource = dSP.LayDSSanPham();
        }
        public void ThemSP(Product p)
        {
            try
            {
                dSP.ThemSP(p);
                MessageBox.Show("Thêm thành công!!");
            }
            catch (Exception)
            {

                MessageBox.Show("Thêm thất bại1!!"); ;
            }
        }
        public void XoaSP(Product p)
        {
            try
            {
                dSP.XoaSP(p);
                MessageBox.Show("Xóa thành công!!");
            }
            catch (Exception)
            {

                MessageBox.Show("Xóa thất bại1!!"); ;
            }
        }
        public void SuaSP(Product p)
        {
            try
            {
                dSP.SuaSP(p);
                MessageBox.Show("Xóa thành công!!");
            }
            catch (Exception)
            {

                MessageBox.Show("Xóa thất bại1!!"); ;
            }
        }
    }
}
