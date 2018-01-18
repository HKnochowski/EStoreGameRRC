using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("GamesTypes")] //Za pomocą atrybutu nadajemy nazwę naszej tabeli
    public class GameType
    {
            [Key] //Klucz główny tabeli
        public int IDGameType { get; set; }
            [Required(ErrorMessage = "Nazwa gatunku jest wymagana")]
            [DisplayName("Gatunek Gry")]
            [StringLength(50)]
            [Column(TypeName = "Gatunek Gry")]
        public string NameGameType { get; set; }

        //Do każdego gatunku możemy przypisać wiele gier
        public virtual ICollection<Game> Games { get; set; }
    }
}