using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("Gallery")]
    public class Gallery
    {
        [Key]
        public int IDGallery { get; set; }
        public string NameGallery { get; set; }
        public DateTime DateAddGallery { get; set; }

        //jedna galeria może mieć jedną grę
        public virtual Game Game { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}