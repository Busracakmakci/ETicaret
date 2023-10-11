using System;

namespace ETicaret
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod paymentMethod = new PaymentMethod();
            paymentMethod.PaymentType = "Kredi Kartı";
            paymentMethod.CardNumber = "1234 5678 9012 3456";
            paymentMethod.ExpiryDate = "12/25";
            paymentMethod.CVV = "123";

            Console.WriteLine(paymentMethod.PaymentType);
        }
    }
}

