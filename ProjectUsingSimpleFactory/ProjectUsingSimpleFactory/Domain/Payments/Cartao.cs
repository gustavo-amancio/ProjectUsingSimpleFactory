using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentUsingSimpleFactory.Domain.Payments
{
    internal class Cartao : Payment
    {
        public Cartao() 
        {
            Name = "Cartão";
        }

        public override void PaymentTransaction(double value)
        {
            Console.WriteLine("O valor R$:{0} foi pago utilizando cartão de crédito", value);
        }

        public override void ReceiveTransaction(double value)
        {
            Console.WriteLine("O valor R$:{0} foi depositado na conta", value);
        }

    }
}
