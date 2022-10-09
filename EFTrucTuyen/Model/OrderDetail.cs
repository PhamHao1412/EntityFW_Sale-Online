using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTrucTuyen.Model
{
     class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OrderId { get; set; }
        public virtual Order OrderTable { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Product ProductTable { get; set; }



    }
}
