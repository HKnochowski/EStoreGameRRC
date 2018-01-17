using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("Game")]
    public class Game
    {
        [Key]
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        // do każdej gry możemy przypisać wiele gatunków gier
        public virtual ICollection<GameType> GamesTypesCollect { get; set; }
        // do każdej gry możemy przypisać wiele platform
        public virtual ICollection<Platform> Platforms { get; set; }
    }
}