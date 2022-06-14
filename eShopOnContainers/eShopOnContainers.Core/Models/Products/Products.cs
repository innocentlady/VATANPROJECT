using System;
using System.Collections.Generic;
using System.Text;

namespace eShopOnContainers.Core.Models.Products
{
     public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public int CategoryID { get; set; }
        public string ImageURL { get; set; }
        public string Detail { get; set; }
   
    }
}

