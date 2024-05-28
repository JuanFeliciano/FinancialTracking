﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracking.Models
{
    public class RevenueEntry : FinancialEntry
    {
        public RevenueEntry(int id,DateOnly date, int value, string description, string category) : base(id,date, value, description, category)
        { }
    }
}
