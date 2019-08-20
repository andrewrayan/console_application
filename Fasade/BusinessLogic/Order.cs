using consoleappliation.Fasade.Skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappliation.Fasade.BusinessLogic
{
    class Order : IOrder
    {
        public void ConfirmationMessage()
        {
            Console.WriteLine("Your order has been added successfully");
        }

        public void PlaceOrder(int productId)
        {
            Console.WriteLine("Order has been added to the database");
        }
    }
}
