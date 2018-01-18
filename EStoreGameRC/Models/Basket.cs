using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("Baskets")]
    public class Basket
    {
        [Key]
        [ForeignKey("Client")]
        public int BasketID { get; set; }
        [Required(ErrorMessage = "Kod referencyjny jest obowiązkowy")]
        [DisplayName("Kod Referencyjny Koszyka")]
        public int CodeBasket { get; set; }

        public virtual ICollection<Copie> Copies { get; set; }
        public virtual Client Client { get; set; }
        public virtual SalesInvoice SalesInvoice { get; set; }
    }
}