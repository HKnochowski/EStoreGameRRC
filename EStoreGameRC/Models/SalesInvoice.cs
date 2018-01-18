using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("SalesInvoice")]
    public class SalesInvoice
    {
        [Key]
        public int SalesInvoiceID { get; set; }
        [Required(ErrorMessage = "Kod Referencyjny faktury jest obowiązkowy")]
        [DisplayName("Kod Referencyjny Faktury")]
        [Column(TypeName = "Kod Faktury")]
        public int CodeSalesInvoice { get; set; }
        [Required(ErrorMessage = "Cena jest obowiązkowa")]
        [DisplayName("Cena/Koszt")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Podanie formy płatności jest obowiązkowe")]
        [DisplayName("Forma płatności")]
        public PaymentMethod PaymentMethod { get; set; }

        [ForeignKey("Basket")]
        public int IDBasket { get; set; }
        [ForeignKey("Client")]
        public int IDClient { get; set; }

        public virtual Basket Basket { get; set; }
        public virtual Client Client { get; set; }
    }
}