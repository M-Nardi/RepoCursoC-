﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioInterface.Services
{
    interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);

        public double Interest(double amount, int months);

    }
}
