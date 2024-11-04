using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class Drug
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Manufactorer { get; set; }
        public string CountryCodeId { get; set; }
    }
}
