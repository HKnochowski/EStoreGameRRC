using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("Video")]
    public class Video
    {
        [Key]
        public int IDVideo { get; set; }
        public string NameVideo { get; set; }
        public DateTime DateAddVideo { get; set; }

        public virtual Gallery Gallery { get; set; }
    }
}