using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Repositories.Abstracts.BaseAbstract;
using ECommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Repositories.Concretes
{
    public class ShipperService : IShipperService
    {
        private readonly IRepository<Shipper> _shipperRepository;

        public ShipperService(IRepository<Shipper> shipperRepository)
        {
            _shipperRepository = shipperRepository;
        }
        public async Task<string> CreateShipper(Shipper shipper)
        {
            return await _shipperRepository.Create(shipper);
        }

        public async Task<string> DeleteShipperAsync(Shipper Shipper)
        {
            return await _shipperRepository.Delete(Shipper);
        }

        public async Task<string> DestroyShipperAsync(Shipper Shipper)
        {
            return await _shipperRepository.DestroyData(Shipper);
        }

        public IEnumerable<Shipper> GetActiveShippers()
        {
            return _shipperRepository.GetActives();
        }

        public IEnumerable<Shipper> GetAllShippers()
        {
            return _shipperRepository.GetAll();
        }

        public IEnumerable<Shipper> GetPassiveShippers()
        {
            return _shipperRepository.GetPassives();
        }

        public Shipper GetShipperById(int id)
        {
            return _shipperRepository.GetById(id);
        }

        public Task<string> UpdateShipperAsync(Shipper Shipper)
        {
            return _shipperRepository.Update(Shipper);
        }
    }
}
