using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixação_aula_196_interface.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
