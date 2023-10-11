using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret
{
    internal interface IPayment // (kredi kartı, Paypal,nakit)
    {
        bool ProcessPayment(decimal amount);
    }
}
