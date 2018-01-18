using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("Client")]
    public class Client
    {
        public Client()
        {
            this.LibraryGames = new HashSet<Game>();
        }

        [Key]
        public int ClientID { get; set; }
        public string LoginClient { get; set; }
        public string PasswordClient { get; set; }
        public string NameClient { get; set; }
        public string SurnameClinet { get; set; }
        public string Avatar { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool IsHeBanned { get; set; }

        public virtual Basket Basket { get; set; }
        public virtual SalesInvoice SalesInvoice { get; set; }
        public virtual ICollection<Game> LibraryGames { get; set; }
        public virtual State State { get; set; }
    }
}