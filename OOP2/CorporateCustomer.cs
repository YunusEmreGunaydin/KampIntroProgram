﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class CorporateCustomer:Customer
    {
        
        //vergi numarası demek
        public string TaxNumber { get; set; }
        public string CompanyName { get; set; }
    }
}
