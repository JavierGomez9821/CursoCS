using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public class PsePayment : IPaymentMode
    {
        public void MakePayment()
        {
            Console.WriteLine("Pago Con PSE Activado");
        }
    }
}