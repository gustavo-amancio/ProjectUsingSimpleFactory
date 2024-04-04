using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentUsingSimpleFactory.Domain.Payments
{
    internal class Cheque : Payment
    {
        public Cheque() 
        {
            Name = "Cheque";
        }

        public override void PaymentTransaction(double value)
        {
            Console.WriteLine("O valor R$:{0} foi recebido utilizando cheque", value);
        }

        public override void ReceiveTransaction(double value)
        {
            Console.WriteLine("O valor R$:{0} foi pago utilizando cheque", value);
        }
    }
}
