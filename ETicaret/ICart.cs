using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret
{
    internal interface ICart
    {
        List<Iproduct> CartItems { get; set; }
        void AddToCart(Iproduct product);
        void RemoveFromCart(Iproduct product);
        void UpdateQuantity(Iproduct ıproduct, int quantity);
    }
}
