using System;
using System.Collections.Generic;
using System.Text;

namespace projetoInterface.Services
{
    interface OnlinePaymentService
    {
        double PaymentFee(Double amount);
        double Interset(Double amount, int months);
    }
}
