using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("Client")]
    public class Client
    {
       /* public Client()
        {
            this.LibraryGames = new HashSet<Game>();
        } */

            [Key]
        public int ClientID { get; set; }
            [Required(ErrorMessage = "Podanie loginu jest obowiązkowe")]
            [DisplayName("Login")]
            [StringLength(50)]
        public string LoginClient { get; set; }
            [Required(ErrorMessage = "Podanie hasła jest obowiązkowe")]
            [DisplayName("Hasło")]
            [StringLength(20)]
        public string PasswordClient { get; set; }
            [DisplayName("Imię")]
            [StringLength(30)]
        public string NameClient { get; set; }
            [DisplayName("Nazwisko")]
            [StringLength(50)]
        public string SurnameClinet { get; set; }
            [DisplayName("Avatar")]
        public string Avatar { get; set; }
            [DisplayName("Czy klient jest zalogowany?")]
        public bool IsLoggedIn { get; set; }
            [DisplayName("Czy klient jest zbanowany?")]
        public bool IsHeBanned { get; set; }

            [ForeignKey("State")]
        public int IDState { get; set; }
            [ForeignKey("WishLists")]
        public int IDWishList { get; set; }

        public virtual Basket Basket { get; set; }
        public virtual SalesInvoice SalesInvoice { get; set; }
        //Biblioteka gier klienta
        public virtual ICollection<Copie> Copies { get; set; }
        public virtual State State { get; set; }
        public virtual WishList WishLists { get; set; }
    }
}