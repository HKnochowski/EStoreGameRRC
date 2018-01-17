using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EStoreGameRC.Models
{
    [Table("Platform")]
    public class Platform
    {

        [Key]
        public int IDPlatform { get; set; }
        [ForeignKey("Game")]
        public int GameID { get; set; }
        public string NamePlatform { get; set; }
        //Będziemy wiedzieć, które gry przynależą do tej Platformy
        public virtual Game Games { get; set; }
        // do każdej platformy możemy przypisać wiele typów
        public virtual ICollection<PlatformType> PlatformsTypes { get; set; }
    }
}