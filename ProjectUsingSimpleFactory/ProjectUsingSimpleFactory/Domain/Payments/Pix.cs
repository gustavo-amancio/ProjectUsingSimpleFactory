using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentUsingSimpleFactory.Domain.Payments
{
    internal class Pix : Payment
    {
         public Pix() 
        {
            Name = "Píx";
        }

        public override void PaymentTransaction(double value)
        {
            Console.WriteLine("O valor R$:{0} foi pago utilizando pix", value);
        }

        public override void ReceiveTransaction(double value)
        {
            Console.WriteLine("O valor R$:{0} foi recebido utilizando pix", value);
        }
    }
}
