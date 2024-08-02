using ECommerce.Model.Base;

namespace ECommerce.Model.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string ImagePath { get; set; }


        //Mapping
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
