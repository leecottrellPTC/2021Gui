using System;
using System.Collections.Generic;

#nullable disable

namespace HenryPractice2.Models
{
    public partial class Bookandcost
    {
        public string Bookcode { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public decimal? Price { get; set; }
    }
}
