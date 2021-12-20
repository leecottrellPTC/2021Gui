using System;
using System.Collections.Generic;

#nullable disable

namespace HenryBooksEF.Models
{
    public partial class Reservation
    {
        public int ResNum { get; set; }
        public int RoomNum { get; set; }
        public int GuestId { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }

        public virtual Customer Guest { get; set; }
    }
}
