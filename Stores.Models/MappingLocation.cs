using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stores.Models
{
    public class MappingLocation
    {
        public int MappingLocationId  { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int TalukId { get; set; }
        public int  ServiceListId { get; set; }
        public string Address { get; set; }
        public string Place { get; set; }




    }
}
