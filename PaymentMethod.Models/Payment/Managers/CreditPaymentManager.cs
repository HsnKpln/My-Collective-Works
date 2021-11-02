using System;
using PaymentMethod.Models.Payment.Abstracts;
using PaymentMethod.Models.Payment.Models;

namespace PaymentMethod.Models.Payment.Managers
{
    public class CreditPaymentManager : IPayable
    {
        public MessageStates State { get; set; }
        public void Pay(PaymentBase payment)
        {
            try
            {
                //ödeme ayarları yapılır

                CreditPayment credit = payment as CreditPayment;
                //işlem başarılı
                State = MessageStates.Success;

                //db işlemleri
                //bildirim işlemleri
                //log işlemleri
            }
            catch (Exception ex)
            {
                //log işlemleri
                //bildirim
                State = MessageStates.Fail;
            }
        }
    }
}