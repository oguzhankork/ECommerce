namespace ECommerce.Common.CartHelpers
{
    public class Cart
    {
        //Sepet Listesi
        public Dictionary<int, CartItem> MyCart = new Dictionary<int, CartItem>();

        //Sepet Metotlar (Eylemler)
        public void AddItem(CartItem cartItem)
        {
            if (MyCart.ContainsKey(cartItem.Id))
            {
                MyCart[cartItem.Id].Quantity += 1;
                return;
            }
            MyCart.Add(cartItem.Id, cartItem);
        }

        public void UpdateItem(int key, int quantity)
        {
            //todo: yapılacak
        }

        public void DeleteItem(int key)
        {
            //todo: yapılacak
        }
    }
}
