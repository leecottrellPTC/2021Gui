using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst.Models
{
    public class LMCOrder
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmpId { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
