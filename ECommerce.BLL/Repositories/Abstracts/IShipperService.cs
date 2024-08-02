using ECommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Repositories.Abstracts
{
    public interface IShipperService
    {
        Task<string> CreateShipper(Shipper shipper);
        IEnumerable<Shipper> GetAllShippers();
        Shipper GetShipperById(int id);
        Task<string> DeleteShipperAsync(Shipper Shipper);
        Task<string> UpdateShipperAsync(Shipper Shipper);
        IEnumerable<Shipper> GetActiveShippers();
        IEnumerable<Shipper> GetPassiveShippers();
        Task<string> DestroyShipperAsync(Shipper Shipper);
    }
}
