using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public class DebitCardPayment : IPaymentMode
    {
        public void MakePayment()
        {
            Console.WriteLine("Pago Con Tarjeta Debito Activado");
        }

    }
}