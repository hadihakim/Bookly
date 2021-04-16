using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int NumberInStock { get; set; }
        
    }
}