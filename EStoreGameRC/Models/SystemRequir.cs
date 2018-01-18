using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("SystemRequirs")]
    public class SystemRequir
    {
        [Key]
        public int SystemRequirID { get; set; }
            [Required(ErrorMessage = "Nazwa procesora jest wymagana")]
            [DisplayName("Nazwa procesora")]
            [StringLength(100)]
            [Column(TypeName = "Procesor")]
        public string Processor { get; set; }
            [Required(ErrorMessage = "Ilość pamięci ram jest wymagane")]
            [DisplayName("Ilość pamięci ram")]
            [Column(TypeName = "Ram")]
        public int MemmoryRam { get; set; }
            [Required(ErrorMessage = "Nazwa karty graficznej jest wymagana")]
            [DisplayName("Nazwa karty graficznej")]
            [StringLength(100)]
            [Column(TypeName = "Karta graficzna")]
        public string Graphics { get; set; }
            [Required(ErrorMessage = "Ilość miejsca na dysku jest wymagana")]
            [DisplayName("Ilość miejsca na dysku")]
            [Column(TypeName = "Dysk twardy")]
        public int Storage { get; set; }

        //Wymagania mogą mieć jedną grę
        public virtual Game Game { get; set; }
    }
}