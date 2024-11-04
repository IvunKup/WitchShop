using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class Country : BaseEntity
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
    }
}
