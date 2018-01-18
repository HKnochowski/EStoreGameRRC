using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EStoreGameRC.Models
{
    [Table("Platforms")]
    public class Platform
    {

            [Key]
        public int PlatformID { get; set; }
            [Required(ErrorMessage ="Nazwa platformy jest wymagana")]
            [DisplayName("Nazwa Platformy")]
            [StringLength(50)]
            [Column(TypeName ="Nazwa Platformy")]
        public string NamePlatform { get; set; }


        public virtual ICollection<Game> Games { get; set; }
        // do każdej platformy możemy przypisać wiele typów
        public virtual ICollection<PlatformType> PlatformsTypes { get; set; }
    }
}