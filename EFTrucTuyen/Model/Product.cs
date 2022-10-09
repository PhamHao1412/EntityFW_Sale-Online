using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTrucTuyen.Model
{
    internal class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required,StringLength(50),Display(Name = "Tên sản phẩm")]
        public string ProductName { get; set; }
        [Display(Name ="Mô tả sản phẩm")]
        public string Description { get; set; }
        [Required , Display(Name ="Giá")]
        public decimal Price { get; set; }
        [Display(Name ="Màu")]
        public string Color { get; set; }
        [Display(Name = "Nhà sản xuất")]
        public string Producer { get; set; }
        [Display(Name = "Ảnh đại diện")]
        public string Image { get; set; }
        [Display(Name = "Người tạo")]
        public string Creator { get; set; }
        [Required,Display(Name = "Danh mục")]
        public int CategoryID { get; set; }
        public virtual Category Cate { get; set; }

    }
}
