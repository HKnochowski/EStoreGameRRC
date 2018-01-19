using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            [Required(ErrorMessage = "Wymagane jest podanie loginu")]
            [DisplayName("Login")]
            [StringLength(40)]
        public string EmployerLogin { get; set; } ///Chyba nie :P ->   //int bo w loginie może być cyfra itp itd
            [Required(ErrorMessage = "Wymagane jest podanie hasła")]
            [DisplayName("Hasło")]
            [StringLength(20)]
        public string EmployerPassword { get; set; }
            [Required(ErrorMessage = "Wymagane jest podanie imienia")]
            [DisplayName("Imię")]
            [StringLength(50)]
        public string EmployerName { get; set; } //dopisek Employer by się nie myliło z klientem
            [Required(ErrorMessage = "Wymagane jest podanie nazwiska")]
            [DisplayName("Nazwisko")]
            [StringLength(50)]
        public string EmployerSurname { get; set; } //dopisek Employer by się nie myliło z klientem
            [DisplayName("Czy konto jest aktywne?")]
        public bool ActiveAccount { get; set; }
            [Required(ErrorMessage = "Data zatrudnienia jest wymagana")]
            [DisplayName("Data Zatrudnienia")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "0:yyyy-MM-dd")]
        public DateTime HireDate { get; set; }
            [DisplayName("Data Zwolnienia")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "0:yyy-MM-dd")]
        public DateTime DismissDate { get; set; }
       
        //Poziom uprawnień? Raczej bym z tego zrezygnował, więcej będzie kombinowania z kodem

        public virtual Address Address { get; set; }
        public virtual Contact Contact { get; set; }



    }
}