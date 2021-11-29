using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst.Models
{
    public class AzureContext : DbContext
    {
        //need properties for each table you want to migrate
        public DbSet <LMCOrder> LMCOrders { get; set; }
        public DbSet <LMCOrderDetails> LMCOrderDetailsTable { get; set; }

        public AzureContext(DbContextOptions<AzureContext> options) : base(options)
        {

        }


    }
}
