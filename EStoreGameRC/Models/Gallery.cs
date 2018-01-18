using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            [ForeignKey("Game")]
        public int GalleryID { get; set; }
            [Required(ErrorMessage = "Nazwa Galerii jest obowiązkowa")]
            [DisplayName("Galeria")]
            [StringLength(100)]
            [Column(TypeName = "Nazwa Galerii")]
        public string NameGallery { get; set; }
            [DisplayName("Data dodania galerii")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "0:yyyy-MM-dd")]
        public DateTime DateAddGallery { get; set; }

        //jedna galeria może mieć jedną grę
        public virtual Game Game { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}