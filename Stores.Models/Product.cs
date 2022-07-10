using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int BrandID { get; set; }
        public int CategoryID { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }
        public string ProductReleaseDate { get; set; }


    }
}
