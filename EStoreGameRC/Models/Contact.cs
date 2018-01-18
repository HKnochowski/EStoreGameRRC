using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("Contacts")]
    public class Contact
    {
        [Key]
        [ForeignKey("Employer")]
        public int ContactID { get; set; }
        [Required(ErrorMessage = "Wymagane jest podanie nr telefonu")]
        [DisplayName("Numer telefonu 1")]
        [StringLength(20)]
        public string PhoneNumber1 { get; set; }
        [DisplayName("Numer telefonu 2")]
        [StringLength(20)]
        public string PhoneNumber2 { get; set; }
        [Required(ErrorMessage = "Wymagany jest adres e-mail")]
        [DisplayName("E-Mail")]
        [StringLength(50)]
        public string Email { get; set; }
        [DisplayName("Strona internetowa")]
        [StringLength(50)]
        public string Website { get; set; }

        public virtual Employer Employer { get; set; }
    }
}