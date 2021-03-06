﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingApi.Models
{
    public interface IRepository
    {
        IEnumerable<Payment> Payments { get; }
        Payment this[int id] { get; }

        void DeletePayment(int id);
    }
}
