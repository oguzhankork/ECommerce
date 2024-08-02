using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels.CreditCartViewModels
{
    public class CreditCartViewModel
    {
        [Display(Name ="Ad")]
        [Required]
        public string Firstname { get; set; }
        [Display(Name = "Soyad")]
        [Required]

        public string Lastname { get; set; }
        [Display(Name = "Kredi Kartı No")]
        [Required]

        public string CreditCartNumber { get; set; }

       

        private string EndDateString { get; set; }

        [Display(Name = "Son Kullanma Tarihi")]
        [Required]
        public DateTime EndDate
        {
            get
            {
                return DateTime.Parse(EndDateString);
            }
            set
            {
                string dateFormat=value.Month+" "+value.Year;
                EndDateString=dateFormat;
            }

        }
    }
}
