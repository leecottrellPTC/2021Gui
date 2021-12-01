using System;
using System.Collections.Generic;

#nullable disable

namespace HenryBooksEF.Models
{
    public partial class Book
    {
        public Book()
        {
            Copies = new HashSet<Copy>();
            Wrotes = new HashSet<Wrote>();
        }

        public string BookCode { get; set; }
        public string Title { get; set; }
        public string PublisherCode { get; set; }
        public string Type { get; set; }
        public string Paperback { get; set; }

        public virtual Publisher PublisherCodeNavigation { get; set; }
        public virtual ICollection<Copy> Copies { get; set; }
        public virtual ICollection<Wrote> Wrotes { get; set; }
    }
}
