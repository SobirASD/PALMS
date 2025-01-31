﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALMS.Data.Objects
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
