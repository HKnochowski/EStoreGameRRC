using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("Basket")]
    public class Basket
    {
        [Key]
        public int BasketID { get; set; }
        public int CodeBasket { get; set; }

        public virtual ICollection<Copie> Copies { get; set; }
        public virtual Client Client { get; set; }
        public virtual SalesInvoice SalesInvoice { get; set; }
    }
}