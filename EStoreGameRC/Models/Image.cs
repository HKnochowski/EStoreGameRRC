using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public int ImageID { get; set; }
            [Required(ErrorMessage = "Nazwa obrazka jest obowiązkowa")]
            [DisplayName("Obrazek")]
            [Column(TypeName = "Obrazek")]
        public string NameImage { get; set; }
            [DisplayName("Data dodania obrazka")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "0:yyyy-MM-dd")]
        public DateTime DateAddImage { get; set; }

        [ForeignKey("Gallery")]
        public int IDGallery { get; set; }

        public virtual Gallery Gallery { get; set; }
    }
}