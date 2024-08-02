using ECommerce.Model.Base;

namespace ECommerce.Model.Entities
{
    public class Order:BaseEntity
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public string OrderNumber { get; set; }

        public virtual AppUser User { get; set; }
        public Guid UserId { get; set; }
        public string? Address { get; set; }
        public int? ShipperId { get; set; }
        public virtual Shipper? Shipper { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; } 
    }
}
