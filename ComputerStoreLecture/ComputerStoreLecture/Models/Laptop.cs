using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerStoreLecture.Models
{
    public class Laptop : Desktop
    {
        public int Screen { get; set; }
        public int Weight { get; set; }

        public Laptop(String name, decimal price, int ram, int screen, int weight):base(name, price, ram)
        {
            Screen = screen;
            Weight = weight;
        }
    }
}
