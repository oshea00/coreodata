using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace nwodata.Models
{
    public partial class OrderDetails
    {
        [Key]
        public int OrderId { get; set; }
        [Key]
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }

        public Orders Order { get; set; }
        public Products Product { get; set; }
    
    }
}
