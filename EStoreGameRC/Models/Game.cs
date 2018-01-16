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
        // do każdego samochodu możemy przypisać wiele komenatrzy
        public virtual ICollection<GameType> GamesTypesCollect { get; set; }
    }
}