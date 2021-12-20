using System;
using System.Collections.Generic;

#nullable disable

namespace HenryPractice.Models
{
    public partial class Book
    {
        public string BookCode { get; set; }
        public string Title { get; set; }
        public string PublisherCode { get; set; }
        public string Type { get; set; }
        public string Paperback { get; set; }
    }
}
