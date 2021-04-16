using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Type { get; set; }
    }
}