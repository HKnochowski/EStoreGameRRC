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
        public Game()
        {
            this.GamesTypesCollect = new HashSet<GameType>();
            this.GamesLanguages = new HashSet<GameLanguage>();
            this.Platforms = new HashSet<Platform>();
        }

        [Key]
        public int GameID { get; set; }
        /*[ForeignKey("GameLanguage")]
        public int IDGameLanguage { get; set; } */
        /*[ForeignKey("GameType")]
        public int IDGameType { get; set; } */
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public string GamePremiere { get; set; }
        public AdditFeatuers AdditFeatuers { get; set; }
        public bool OrToBuy { get; set; }
        // do każdej gry możemy przypisać wiele gatunków gier
        public virtual ICollection<GameType> GamesTypesCollect { get; set; }
        // do każdej gry możemy przypisać wiele platform
        public virtual ICollection<Platform> Platforms { get; set; }
        // do każdej gry możemy przypisać wiele języków
        public virtual ICollection<GameLanguage> GamesLanguages { get; set; }
        // jedna gra może mieć jedną galerię
        public virtual Gallery Gallery { get; set; }
        //gra może mieć jednego wydawcę
        public virtual GamePublisher GamePublisher { get; set; }
        //gra może mieć jedno wymaganie
        public virtual SystemRequir SystemRequir { get; set; }

        public virtual ICollection<Copie> Copies { get; set; }
        public virtual ICollection<WishList> WishesLists { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}