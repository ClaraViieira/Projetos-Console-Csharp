﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Console2HerancaEPolimorfismo.Entities {
    class UsedProduct : Product {
        public DateTime ManufactureDate { get; set; }
        public UsedProduct() {
        }
        public UsedProduct(string name, double price, DateTime manufactureDate) :base(name, price) {
            ManufactureDate = manufactureDate;
        }
        public override string PriceTag() {
            return Name
            + " (used) $ "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + " (Manufacture date: "
            + ManufactureDate.ToString("dd/MM/yyyyy")
            + ")";
        }
    }
}
