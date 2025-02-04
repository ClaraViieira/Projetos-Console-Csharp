﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInterfaces.Services {
    class BrazilTaxService : ITaxService {
        public double Tax(double amount) {
            if (amount <= 100.00)
                return amount * 0.20;
            else
                return amount * 0.15;
        }
    }
}
