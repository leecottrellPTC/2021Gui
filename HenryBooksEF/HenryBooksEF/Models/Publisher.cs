using System;
using System.Collections.Generic;

#nullable disable

namespace HenryBooksEF.Models
{
    public partial class Publisher
    {
        public Publisher()
        {
            Books = new HashSet<Book>();
        }

        public string PublisherCode { get; set; }
        public string PublisherName { get; set; }
        public string City { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
