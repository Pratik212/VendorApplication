using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VendorApplication.Data;
using VendorApplication.Dtos;
using VendorApplication.Models;

namespace VendorApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly VendorContext _context;
        private readonly Settings _settings;

        public HomeController(VendorContext context , IOptions<Settings> settings)
        {
            _context = context;
            _settings = settings.Value;
        }
        public IActionResult Index()
        {
            return View(new VendorRegistration());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult AddVendor(Vendor vendor)
        {

            var addVendor = _context.Vendors.Add(vendor);
            _context.SaveChanges();
            ViewBag.VendorTitle = "Vendor Details Successfully Added.";
            return View("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult AddBank(BankDto bankDetail)
        {
            AddBankDetail(bankDetail);
            ViewBag.title = "Bank Details Successfully Added.";
            return View("Index");
        }

        private void AddBankDetail(BankDto bankDetail)
        {
            var addBankDetail = new BankDetail
            {

                BankName = bankDetail.BankName,
                AccountNumber = bankDetail.AccountNumber,
                BranchName = bankDetail.BranchName,
                AccountType = bankDetail.AccountType,
                MicrNo = bankDetail.MicrNo,
                IfscCode = bankDetail.IfscCode,
                Neft = bankDetail.Neft
            };

            if (bankDetail.UploadCheque != null)
            {
                var uploadChequefileName = $"{addBankDetail.Id}_{bankDetail.UploadCheque.FileName}";


                var path = Path.Combine(
                  Directory.GetCurrentDirectory(), _settings.DocumentsPath,
                  uploadChequefileName);

                addBankDetail.UploadCheque = uploadChequefileName;
            }

            if (bankDetail.UploadGstCertificate != null)
            {
                var fileName = $"{addBankDetail.Id}_{bankDetail.UploadGstCertificate.FileName}";


                var path = Path.Combine(
                  Directory.GetCurrentDirectory(), _settings.DocumentsPath,
                  fileName);

                addBankDetail.UploadGstCertificate = fileName;
            }


            if (bankDetail.UploadPancard != null)
            {
                var fileName = $"{addBankDetail.Id}_{bankDetail.UploadPancard.FileName}";


                var path = Path.Combine(
                  Directory.GetCurrentDirectory(), _settings.DocumentsPath,
                  fileName);

                addBankDetail.UploadPancard = fileName;
            }

            _context.BankDetails.Add(addBankDetail);
            _context.SaveChanges();

           
        }
    }
}
