using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("Games")]
    public class Game
    {
       /* public Game()
        {
            this.GamesTypesCollect = new HashSet<GameType>();
            this.GamesLanguages = new HashSet<GameLanguage>();
            this.Platforms = new HashSet<Platform>();
        }   */

            [Key]
        public int GameID { get; set; }
            [Required(ErrorMessage = "Nazwa gry jest wymagana")]
            [DisplayName("Nazwa Gry")]
            [StringLength(100)]
            [Column(TypeName = " Nazwa Gry")]
        public string GameName { get; set; }
            [Required(ErrorMessage = "Opis gry jest wymagany")]
            [DisplayName("Opis Gry")]
            [StringLength(2000)]
            [Column(TypeName = " Opis Gry")]
        public string GameDescription { get; set; }
            [DisplayName("Data Premiery")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "0:yyyy-MM-dd")]
            [Column(TypeName = "Data Premiery")]
        public string GamePremiere { get; set; }
            [DisplayName("Dodatkowe cechy")]
            [Column(TypeName = "Dodatkowe cechy")]
        public AdditFeatuers AdditFeatuers { get; set; }
            [DisplayName("Czy jest do kupienia?")]
            [Column(TypeName = "OrToBuy")]
        public bool OrToBuy { get; set; }

            [ForeignKey("GamePublisher")]
        public int IDGamePublisher { get; set; }

            [ForeignKey("SystemRequirs")]
        public int IDSystemRequirs { get; set; }

        // do każdej gry możemy przypisać wiele gatunków gier
        public virtual ICollection<GameType> GamesTypes { get; set; }
        // do każdej gry możemy przypisać wiele platform
        public virtual ICollection<Platform> Platforms { get; set; }
        // do każdej gry możemy przypisać wiele języków
        public virtual ICollection<GameLanguage> GamesLanguages { get; set; }
        // jedna gra może mieć jedną galerię
        public virtual Gallery Gallery { get; set; }
        //gra może mieć jednego wydawcę
        public virtual GamePublisher GamePublisher { get; set; }
        //gra może mieć jedno wymaganie
        public virtual SystemRequir SystemRequirs { get; set; }

        public virtual ICollection<Copie> Copies { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}