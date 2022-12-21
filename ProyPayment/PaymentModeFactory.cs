using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;



namespace Interfaces
{
    public enum Mode
    {
        CreditCard,
        DebitCard,
        PayPal,
        Pse
    }
    public class PaymentModeFactory
    {
        public static IPaymentMode Create(Mode mode)
        {
            if (mode == Mode.CreditCard)
                return new CreditCardPayment();
            else if (mode == Mode.DebitCard)
                return new DebitCardPayment();
            else if (mode == Mode.PayPal)
                return new PayPalPayment();
            else
                return new PsePayment();
        }
    }
}