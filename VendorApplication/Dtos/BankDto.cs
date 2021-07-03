using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendorApplication.Dtos
{
    public class BankDto
    {

        public string BankName { get; set; }

        public int AccountNumber { get; set; }
        public string BranchName { get; set; }

        public string AccountType { get; set; }

        public int MicrNo { get; set; }

        public string IfscCode { get; set; }

        public string Neft { get; set; }

        public IFormFile UploadCheque { get; set; }

        public IFormFile UploadGstCertificate { get; set; }

        public IFormFile UploadPancard { get; set; }
    }
}
