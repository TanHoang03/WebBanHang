using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WbeBanHang.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="ban chua nhap du lieu"), StringLength(50)]
        public String Name { get; set; }
        [Range(1, 100,ErrorMessage ="du lieu tu 1 -> 100")]
        public int DisplayOrder { get; set; }
    }
}
