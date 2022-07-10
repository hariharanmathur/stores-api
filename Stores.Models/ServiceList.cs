using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Models
{
    public class ServiceList
    {
        public int ServiceListId { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string? Model { get; set; }
        public string? CustomerName { get; set; }
        public string? JobCardStatus { get; set; }
        public string? Description { get; set; }
        public string? ServiceAllocatedTo { get; set; }

        public DateTime? DateOfPurchase { get; set; }
        public string? JobCardNumber { get; set; }
        public string? PhoneNumber { get; set; }



    }
}
