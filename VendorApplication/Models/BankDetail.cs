using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VendorApplication.Models
{
    public class BankDetail
    {
        [Key]
        public int Id { get; set; }

        public string BankName { get; set; }

        public int AccountNumber { get; set; }

        public string BranchName { get; set; }

        public string AccountType { get; set; }

        public int MicrNo { get; set; }

        public string IfscCode { get; set; }

        public string Neft { get; set; }

        public string UploadCheque { get; set; }

        public string UploadGstCertificate { get; set; }

        public string UploadPancard { get; set; }
    }
}
