using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WbeBanHang.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        // bo sung moi kket hop
        //[Foreignkey("OrdderId")]
        public Order Order { get; set; }
        public Orders Product { get; set; }
    }
}
