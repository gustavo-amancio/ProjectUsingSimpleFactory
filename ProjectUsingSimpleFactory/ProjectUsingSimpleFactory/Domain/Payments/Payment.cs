using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentUsingSimpleFactory.Domain.Payments
{
    public abstract class Payment
    {
        public string Name { get; set; } = string.Empty;
        public abstract void PaymentTransaction(double value);
        public abstract void ReceiveTransaction(double value);
    }
}
