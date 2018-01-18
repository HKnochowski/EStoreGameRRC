using System;
using System.Collections.Generic;
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
        public int ContactID { get; set; }
        [ForeignKey("Employer")]
        public int EmployerID { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }

        public virtual Employer Employers { get; set; }
    }
}