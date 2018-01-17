using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("Image")]
    public class Image
    {
        [Key]
        public int IDImage { get; set; }
        public string NameImage { get; set; }
        public DateTime DateAddImage { get; set; }

        public virtual Gallery Gallery { get; set; }
    }
}