using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("PlatformsTypes")]
    public class PlatformType
    {
                [Key]
            public int PlatformTypeID { get; set; }
                [Required(ErrorMessage ="Nazwa typu platformy jest wymagana")]
                [DisplayName("Nazwa typu platformy")]
                [StringLength(50)]
                [Column(TypeName ="Typ platformy")]
            public string NamePlatformType { get; set; }

                [ForeignKey("Platforms")]
            public int IDPlatform { get; set; }

        // Będziemy wiedzieć, które Platformy przynależą do danego typu
            public virtual Platform Platforms { get; set; }
        
    }
}