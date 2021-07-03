using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendorApplication.Models;

namespace VendorApplication.Data
{
    public class VendorContext : DbContext
    {
        public VendorContext(DbContextOptions<VendorContext>options) : base(options)
        {
        }

        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<BankDetail> BankDetails { get; set; }
    }
}
