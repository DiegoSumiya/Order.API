using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Models
{
    public class OrderItemModel : EntityBase
    {
        public OrderModel Order { get; set; }
        public ProductModel Product { get; set; }
        public double SellValue { get; set; }
        public int Stock { get; set; }
        public double TotalAmount { get; set; }
    }
}
