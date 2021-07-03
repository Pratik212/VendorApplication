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

        [Required]
        public string BankName { get; set; }

        [Required]
        public int AccountNumber { get; set; }

        [Required]
        public string BranchName { get; set; }

        [Required]
        public string AccountType { get; set; }

        public int MicrNo { get; set; }

        [Required]
        public string IfscCode { get; set; }

        [Required]
        public string Neft { get; set; }

        [Required]
        public string UploadCheque { get; set; }

        [Required]
        public string UploadGstCertificate { get; set; }

        [Required]
        public string UploadPancard { get; set; }
    }
}
