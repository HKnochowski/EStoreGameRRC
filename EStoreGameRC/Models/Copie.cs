using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("Copies")]
    public class Copie
    {
            [Key]
        public int CopieID { get; set; }
            [Required(ErrorMessage = "Kod Referencyjny Egzemplarza Gry jest obowiązkowy")]
            [DisplayName("Kod Referencyjny Egzemplarza")]
        public int CopieCode { get; set; }
            [DisplayName("Czy gra została sprzedana/kupiona")]
        public bool OrToSale { get; set; }

            [ForeignKey("Baskets")]
        public int IDBasket { get; set; }
            [ForeignKey("Client")]
        public int IDClient { get; set; }

        public virtual Game Game { get; set; }
        public virtual Basket Baskets { get; set; }
        public virtual Client Client { get; set; }
    }
}