using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VendorApplication.Data;
using VendorApplication.Models;

namespace VendorApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly VendorContext _context;

        public HomeController(VendorContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddVendor()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public  IActionResult AddVendor(Vendor vendor)
        {
            var addvendor = _context.Vendors.Add(vendor);

            _context.SaveChanges();
            return View(addvendor);
        }
    }
}
