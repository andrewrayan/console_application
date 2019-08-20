using consoleappliation.Fasade.Skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappliation.Fasade.BusinessLogic
{
    class PurchaseItem : IPurchaseItem
    {
        IOrder _order;
        ICart _cart;
        public PurchaseItem(IOrder order,ICart cart)
        {
            _order = order;
            _cart = cart;
        }

        public void AddToCart(int productId)
        {
            _cart.AddToCart(productId);
            _cart.VerifyStock(productId);
            _cart.LockItem(productId);
        }

        public void PlaceOrder(int productId)
        {
            _order.PlaceOrder(productId);
            _order.ConfirmationMessage();
        }
    }
}
