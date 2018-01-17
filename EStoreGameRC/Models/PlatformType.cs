using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("PlatformType")]
    public class PlatformType
    {
            [Key]
            public int IDPlatformType { get; set; }
            public string NamePlatformType { get; set; }
        // Będziemy wiedzieć, które Platformy przynależą do danego typu
            public virtual Platform Platforms { get; set; }
        
    }
}