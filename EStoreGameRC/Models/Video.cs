using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int VideoID { get; set; }
            [Required(ErrorMessage = "Nazwa Wideo jest obowiązkowa")]
            [DisplayName("Wideo")]
            [StringLength(100)]
            [Column(TypeName = "Nazwa Wideo")]
        public string NameVideo { get; set; }
            [DisplayName("Data dodania wideo")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "0:yyyy-MM-dd")]
        public DateTime DateAddVideo { get; set; }

            [ForeignKey("Gallery")]
        public int IDGallery { get; set; }

        public virtual Gallery Gallery { get; set; }
    }
}