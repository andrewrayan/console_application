using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleappliation.Fasade.Skeleton
{
    public interface ICart
    {
        void AddToCart(int productId);
        void VerifyStock(int productId);
        void LockItem(int productId);
    }
}
