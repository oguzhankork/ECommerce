using ECommerce.Model.Entities;
using ECommerce.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels.ShipperViewModels
{
    public class ShipperViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Taşıyıcı Adı")]
        [Required(ErrorMessage = "Taşıyıcı adı boş geçilemez!")]
        public string CompanyName { get; set; }

        [Display(Name = "Aktif")]

        public bool IsActive { get; set; }

        [Display(Name = "Durum")]
        public DataStatus Status { get; set; }

        public List<Order> Orders { get; set; }
    }
}
