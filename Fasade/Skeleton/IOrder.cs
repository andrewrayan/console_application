using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappliation.Fasade.Skeleton
{
    public interface IOrder
    {
        void PlaceOrder(int productId);
        void ConfirmationMessage();
    }
}
