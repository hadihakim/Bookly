﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class Book
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public string Genre { get; set; }
        public int NumberInStock { get; set; }
        
    }
}