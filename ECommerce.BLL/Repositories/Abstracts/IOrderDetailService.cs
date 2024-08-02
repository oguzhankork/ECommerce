using ECommerce.Model.Entities;

namespace ECommerce.BLL.Repositories.Abstracts
{
    public interface IOrderDetailService
    {
        //List
        IEnumerable<OrderDetail> GetOrderDetails();
        //Create
        Task<string> CreateOrderDetail(OrderDetail orderDetail);
    }
}
