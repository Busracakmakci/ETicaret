using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret
{
    internal interface Iproduct
    {
        string Name { get; set; }
        decimal Price { get; set; } 
        int StockQuantity {  get; set; }

    }

}
