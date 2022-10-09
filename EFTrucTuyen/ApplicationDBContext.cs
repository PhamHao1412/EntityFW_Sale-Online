using EFTrucTuyen.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EFTrucTuyen
{
    internal class ApplicationDBContext :DbContext
    {
        //Ket noi den database
        public ApplicationDBContext() : base("cnStr")
        {   
        }
        //Tao 3 bang
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }






    }
}
