using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class DrugItem : BaseEntity
    {
        public Guid DrugId { get; set; }
        public Guid DrugStireId { get; set; }
        public decimal DrugPrice { get; set; }
    }
}
