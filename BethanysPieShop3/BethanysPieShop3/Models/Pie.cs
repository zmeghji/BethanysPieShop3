using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShop3.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }
    }
}
