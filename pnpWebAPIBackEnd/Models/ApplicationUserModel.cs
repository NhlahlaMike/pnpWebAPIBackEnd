using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pnpWebAPIBackEnd.Models
{
    public class ApplicationUserModel
    {      
        public string UserName { get; set; }
        public string Email { get; set; }        
        public string Title { get; set; }      
        public string FirstName { get; set; }      
        public string Surname { get; set; }       
        public string Nationality { get; set; }        
        public string Identification { get; set; }       
        public string DateofBirth { get; set; }        
        public string Gender { get; set; }       
        public string PhoneNumber { get; set; }        
        public string HomeNumber { get; set; }        
        public string WorkNumber { get; set; }        
        public string AddressType { get; set; }        
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }        
        public string City { get; set; }       
        public string PostalCode { get; set; }       
        public string Province { get; set; }        
        public string CommsMethod { get; set; }        
        public string UserType { get; set; }       
        public string Password { get; set; }        
        public string LoginStatus { get; set; }       
        public string Active { get; set; }
    }
}
