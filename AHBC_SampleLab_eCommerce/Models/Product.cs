using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AHBC_SampleLab_eCommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Descirption { get; set; }
        public double Price { get; set; }

    }
}