using System;
using System.Collections.Generic;
using System.Text;

namespace projetoInterface.Services
{
    class PaypalService : OnlinePaymentService
    {
        private const double MonthlySimple = 0.01;
        private const double PaymentTax = 0.02;

        public double Interset(double amount, int months)
        {
            return amount * months * MonthlySimple;
        }

        public double PaymentFee(double amount)
        {
            return amount * PaymentTax;
        }
    }
}
