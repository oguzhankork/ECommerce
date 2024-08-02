using ECommerce.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ViewModels.AppUserViewModels
{
    public class AppUserListViewModel
    {
        public string ID { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }

        public bool EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDate { get; set; }

    }
}
