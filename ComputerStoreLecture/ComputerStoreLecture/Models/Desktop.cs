﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerStoreLecture.Models
{
    public class Desktop
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int RAM { get; set; }

        public Desktop(string name, decimal price, int rAM)
        {
            Name = name;
            Price = price;
            RAM = rAM;
        }

        public Desktop()
        {
        }
    }
}
