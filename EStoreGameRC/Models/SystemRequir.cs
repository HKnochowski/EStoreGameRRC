using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("SystemRequir")]
    public class SystemRequir
    {
        [Key]
        public int IDSystemRequir { get; set; }
        public string Processor { get; set; }
        public int MemmoryRam { get; set; }
        public string Graphics { get; set; }
        public int Storage { get; set; }

        //Wymagania mogą mieć jedną grę
        public virtual Game Game { get; set; }
    }
}