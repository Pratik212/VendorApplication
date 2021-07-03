using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendorApplication.Models;

namespace VendorApplication.Dtos
{
    public class VendorRegistration
    {
        public Vendor Vendor { get; set; }

        public BankDto BankDetail { get; set; }
    }
}
