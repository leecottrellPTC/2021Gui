using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst.Models
{
    public class LMCOrderDetails
    {
        [Key]
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        
        public int Quantity { get; set; }
        public LMCOrder Order { get; set; }
        public String Notes { get; set; }
    }
}
