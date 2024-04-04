using PaymentUsingSimpleFactory.Domain.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentUsingSimpleFactory.Domain
{
    public sealed class PaymentSimpleFactory
    {
        public static Payment DoItPayment(TypePayment typePayment)
        {
            Payment payment;

            switch (typePayment)
            {
                case TypePayment.Boleto:
                    payment = new Boleto();
                    break;
                case TypePayment.Pix:
                    payment = new Pix();
                    break;
                case TypePayment.Cheque:
                    payment = new Cheque();
                    break;
                case TypePayment.Cartao:
                    payment = new Cartao();
                    break;
                default:
                    throw new ArgumentException($"O tipo enviado não foi implementado");
            }

            return payment;
        }
    }
}
