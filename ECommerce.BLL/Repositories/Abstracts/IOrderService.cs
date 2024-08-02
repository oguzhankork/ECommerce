using ECommerce.Model.Entities;

namespace ECommerce.BLL.Repositories.Abstracts
{
    public interface IOrderService
    {
        //List
        IEnumerable<Order> GetAllOrders();

        //Create
        Task<string> CreateOrder(Order order);

        //Get
        Order GetOrderById(int id);

        

    }
}
