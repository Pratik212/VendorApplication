using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VendorApplication.Models
{
    public class Vendor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        public string NameOfBussiness { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Address1 { get; set; }

        [Required]
        public string Address2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PinNo { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string OfficePhoneNo { get; set; }

        [Required]
        public string ResidencePhoneNo { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string FactoryPhoneNo { get; set; }

        [Required]
        public string PhoneNo { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Website { get; set; }
    }
}
