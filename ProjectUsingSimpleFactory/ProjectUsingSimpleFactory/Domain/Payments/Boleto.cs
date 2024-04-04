using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentUsingSimpleFactory.Domain.Payments
{ 
    internal class Boleto : Payment
    {
        public Boleto() 
        {
            Name = "Boleto";
        }

        public override void PaymentTransaction(double value)
        {
            Console.WriteLine("O valor R$:{0} foi pago utilizando a conta", value);
        }

        public override void ReceiveTransaction(double value)
        {
            Console.WriteLine("Foi recebido via boleto o valor de R$:{0}. O valor pago foi depositado na conta", value);
        }
    }
}
