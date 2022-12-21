using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public class PaymentManager
    {
        // private readonly CreditCardPayment _creditCard;
        // private readonly DebitCardPayment _debitCard;
        // private readonly PayPalPayment _paypalpay;
        private readonly IPaymentMode _paymentMode;

        // public PaymentManager(CreditCardPayment creditCard, DebitCardPayment debitCard, PayPalPayment paypalPay)
        // {
        //     this._creditCard = creditCard;
        //     this._debitCard = debitCard;
        //     this._paypalpay = paypalPay;
        // }
        public PaymentManager(IPaymentMode paymentMode){
            _paymentMode=paymentMode;
        }
        public void ManagePayment()
        {
            // _creditCard.MakePayment();
            // _debitCard.MakePayment();
            // _paypalpay.MakePayment();
            _paymentMode.MakePayment();
        }

    }
}