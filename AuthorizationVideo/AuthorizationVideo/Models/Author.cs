using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AuthorizationVideo.Models
{
    public partial class Author
    {
        [Key]
        public decimal AuthorNum { get; set; }
        public string? AuthorLast { get; set; }
        public string? AuthorFirst { get; set; }
        public string? ImgPath { get; set; }
    }
}
