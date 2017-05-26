using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AW_Demo01.Models
{
    public class Product
    {
          
       public   int ID { set; get; }
        public String Name { set; get; }
        public decimal Price { set; get; }
        public decimal Stock { set; get; }
    }
}