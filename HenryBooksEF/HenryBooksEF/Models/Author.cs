using System;
using System.Collections.Generic;

#nullable disable

namespace HenryBooksEF.Models
{
    public partial class Author
    {
        public Author()
        {
            Wrotes = new HashSet<Wrote>();
        }

        public decimal AuthorNum { get; set; }
        public string AuthorLast { get; set; }
        public string AuthorFirst { get; set; }

        public virtual ICollection<Wrote> Wrotes { get; set; }
    }
}
