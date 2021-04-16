using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //This is the foreign key connecting Reservation model with book model in the DB
        public Book Book { get; set; }
        public int BookID { get; set; }
        //This is the foreign key connecting Reservation model with book model in the DB
        public Client Client { get; set; }
        public int CustomerID { get; set; }


    }
}