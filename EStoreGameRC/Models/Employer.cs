using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace EStoreGameRC.Models
{
    [Table("Employers")]
    public class Employer
    {
        [Key]
        public int EmployerID { get; set; }
        [ForeignKey("Address")]
        public int AddressID { get; set; }
        [ForeignKey("Contact")]
        public int ContactID { get; set; }
        public int Login { get; set; } //int bo w loginie może być cyfra itp itd
        public int Password { get; set; }
        public string EmployerName { get; set; } //dopisek Employer by się nie myliło z klientem
        public string EmployerSurname { get; set; } //dopisek Employer by się nie myliło z klientem
        public bool ActiveAccount { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime DismissDate { get; set; }
       
        //Poziom uprawnień? Raczej bym z tego zrezygnował, więcej będzie kombinowania z kodem

        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }



    }
}