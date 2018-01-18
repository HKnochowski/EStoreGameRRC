using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("Copie")]
    public class Copie
    {
        [Key]
        public int CopieID { get; set; }
        public int CopieCode { get; set; }
        public bool OrToSale { get; set; }

        public virtual Game Game { get; set; }
        public virtual Basket Basket { get; set; }
    }
}