using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret
{
    internal interface IOrder
    {
        Customer customer { get; set; }
        Adress ShipppingAddress { get; set; }
        PaymentMethod PaymentMethod { get; set; }   
        List<Iproduct> OrderItems {  get; set; }

    }
    class Customer
    {
        public string Email { get; set; }
    }
    class Adress
    {
        public string HomeAdress { get; set; }

    }
    public class PaymentMethod
    {
        public string PaymentType { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }

    }
 
}
