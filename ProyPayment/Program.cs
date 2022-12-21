using System.Reflection;
namespace Interfaces
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            PaymentModeFactory.Create(Mode.CreditCard).MakePayment();
            PaymentModeFactory.Create(Mode.DebitCard).MakePayment();
            PaymentModeFactory.Create(Mode.PayPal).MakePayment();
            PaymentModeFactory.Create(Mode.Pse).MakePayment();
        }
    }

}