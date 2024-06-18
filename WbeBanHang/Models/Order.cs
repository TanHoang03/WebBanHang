using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WbeBanHang.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        [Required(ErrorMessage="Vui lòng nhập họ tên vào")]
        public string  CustomerName {get; set;}
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ vào")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại vào")]
        public string Phone { get; set; }
        public double Total
        {
            get;set;
        }
        public string State { get; set; }

    }
}
