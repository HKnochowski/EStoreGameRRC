using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [ForeignKey("Employer")]
        public int AddressID { get; set; }
        [Required(ErrorMessage = "Wymagane jest podanie nazwy miasta")]
        [DisplayName("Miasto")]
        [StringLength(100)]
        public string Town { get; set; }
        [DisplayName("Województwo")]
        [StringLength(50)]
        public string Voivodeship { get; set; } //gdyby ktoś nie wiedzał jak ja to jest to województwo xD
        [DisplayName("Powiat")]
        [StringLength(50)]
        public string Country { get; set; } //a to powiat :D
        [Required(ErrorMessage = "Wymagane jest podanie kodu pocztowego")]
        [DisplayName("Kod Pocztowy")]
        [StringLength(6)]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Wymagane jest podanie ulicy zamieszkania")]
        [DisplayName("Ulica")]
        [StringLength(100)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Wymagane jest podanie numeru domu miejsca zamieszkania")]
        [DisplayName("Numer domu")]
        [StringLength(3)]
        public string HouseNumber { get; set; }
        [DisplayName("Numer mieszkania")]
        [StringLength(10)]
        public string ApartmentNumber { get; set;  }

        public virtual Employer Employer { get; set; }
    }
}