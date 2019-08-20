using consoleappliation.Fasade.Skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappliation.Fasade.BusinessLogic
{
    class Cart : ICart
    {
        public void AddToCart(int productId)
        {
            Console.WriteLine($"Product with id {productId} has been added to cart successfully");
        }

        public void LockItem(int productId)
        {
            Console.WriteLine($"Product with id {productId} has been locked");
        }

        public void VerifyStock(int productId)
        {
            Console.WriteLine($"Product with id {productId} has been verified in stock");
        }
    }
}
