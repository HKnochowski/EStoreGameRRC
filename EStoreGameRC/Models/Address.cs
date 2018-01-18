using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace EStoreGameRC.Models
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        [ForeignKey("Employer")]
        public int EmployerID { get; set; }
        public string Town { get; set; }
        public string Voivodeship { get; set; } //gdyby ktoś nie wiedzał jak ja to jest to województwo xD
        public string Country { get; set; } //a to powiat :D
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set;  }

        public virtual Employer Employers { get; set; }
    }
}