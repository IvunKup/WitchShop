using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class DrugStore
    {
        public int Number {get; set;}
        public Address Address { get; set; }
        public string DrugNetwork { get; set; }
    }
}
