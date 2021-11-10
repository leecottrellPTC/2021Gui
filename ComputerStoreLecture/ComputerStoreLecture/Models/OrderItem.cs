using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ComputerStoreLecture.Models
{
    public class OrderItem
    {
        //make a field nullable
        //put ? after data type
        [Required(ErrorMessage = "You have to have a processor")]
        public String Processor { get; set; }
        [Required(ErrorMessage = "Please enter RAM between 4 and 32")]
        [Range(4, 32, ErrorMessage = "Please enter {0} between {1} and {2}")]
        public int? RAM { get; set; }
        [Range(2, 4, ErrorMessage = "Please enter {0} between {1} and {2} Ghz")]
        [Required(ErrorMessage = "Please enter RAM between 2 and 4 Ghz")]
        public double? Speed { get; set; }
        [Required(ErrorMessage = "Please enter Hard Drive Size Speed between 1 and 4 Ghz")]
        [Range(1, 4, ErrorMessage = "Please enter  {0} between {1} and {2} Tb")]
        public double? HDSize { get; set; }
        [Required(ErrorMessage ="We need a valid email address")]
        //[DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", 
            ErrorMessage ="Enter an email like you@domain.com")]
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
