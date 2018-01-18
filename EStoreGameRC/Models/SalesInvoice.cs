using System;
using System.Collections.Generic;
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
        public int CodeSalesInvoice { get; set; }
        public double Price { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public virtual Basket Basket { get; set; }
        public virtual Client Client { get; set; }
    }
}