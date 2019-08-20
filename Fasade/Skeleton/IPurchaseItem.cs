using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappliation.Fasade.Skeleton
{
    interface IPurchaseItem
    {
        void AddToCart(int productId);
        void PlaceOrder(int productId);
    }
}
