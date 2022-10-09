using EFTrucTuyen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTrucTuyen.DAO
{
     class DAO_SanPham
    {
        ApplicationDBContext db;
        public DAO_SanPham()
            {
              db = new ApplicationDBContext();
            }
        public dynamic LayDSSanPham()
        {
            var ds = db.Products.Select(s => new
            {
                s.ProductId,
                s.ProductName,
                s.Price,
                s.Cate.CategoryName
            }).ToList();
            return ds;
        }
        public dynamic LayDSLoaiSP()
        {
            var ds = db.Categories.Select(s => new
            {
                s.CategoryId,
                s.CategoryName
            }).ToList();
            return ds;
        }
        public void ThemSP(Product p )
        {
            db.Products.Add(p);
            db.SaveChanges();
        }
        public void XoaSP(Product p)
        {
            Product pro  = db.Products.Find(p.ProductId);
            db.Products.Remove(pro);
            db.SaveChanges();
        }
        public void SuaSP(Product d)
        {
            Product pro = db.Products.Find(d.ProductId);
            pro.ProductName = d.ProductName; 
            pro.Price = d.Price;
            pro.CategoryID = d.CategoryID;
            db.SaveChanges();
        }

    }
 }


