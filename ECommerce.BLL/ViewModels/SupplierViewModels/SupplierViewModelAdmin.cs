using ECommerce.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels.SupplierViewModels
{
    public class SupplierViewModelAdmin
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string? PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public DataStatus Status { get; set; }
    }
}
