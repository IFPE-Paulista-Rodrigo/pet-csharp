using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOClasse.Partial
{
    partial class PaymentForm
    {
        partial void ValidatePayment(decimal amount)
        {
            if (amount > 100)
            {
                Console.WriteLine($"Amount > {amount}");
            }
        }
    }
}
