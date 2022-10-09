using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTrucTuyen.Model
{
    internal class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required , StringLength(50),Display(Name ="Tên danh mục")]
        public string CategoryName { get; set; }
        [Display(Name ="Mô tả chi tiết")]
        public string Description { get; set; } 
    }
}
