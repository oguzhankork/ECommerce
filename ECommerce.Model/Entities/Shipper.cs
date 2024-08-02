using ECommerce.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Model.Entities
{
    public class Shipper : BaseEntity
    {
        public Shipper()
        {
            Orders = new List<Order>();
        }

        public string CompanyName { get; set; }

        //Mapping
        public virtual List<Order>? Orders { get; set; }
    }
}
