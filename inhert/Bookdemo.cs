﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhert
{
    internal class Bookdemo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public PublisherDemo Publisher { get; set; }
    }
}
