using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pnpWebAPIBackEnd.Models
{
    public class Users
    {
        [Key]
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Surname { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Nationality { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Identification { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string DateofBirth { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Gender { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string HomeNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string WorkNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string AddressType { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string City { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string PostalCode { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Province { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string CommsMethod { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string UserType { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string LoginStatus { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Active { get; set; }
    }
}
