using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerStoreLecture.Models
{
    public class OrderItem
    {
        public String Processor { get; set; }
        public int RAM { get; set; }
        public double Speed { get; set; }
        public double HDSize { get; set; }
        public String Email { get; set; }

        public OrderItem(string processor, int rAM, double speed, double hDSize, string email)
        {
            Processor = processor;
            RAM = rAM;
            Speed = speed;
            HDSize = hDSize;
            Email = email;
        }

        public OrderItem()
        {
        }
    }
}
