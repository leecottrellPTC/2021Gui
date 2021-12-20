using System;
using System.Collections.Generic;

#nullable disable

namespace HenryBooksEF.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int CustId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string PayDetails { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
