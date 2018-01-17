using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("GameLanguage")]
    public class GameLanguage
    {
        [Key]
        public int IDGameLanguage { get; set; }
        [ForeignKey("Game")]
        public int GameID { get; set; }
        public string NameLanguage { get; set; }
        // Do każdego języka możemy przypisać wiele gier
        public virtual ICollection<Game> Games { get; set; }
    }
}