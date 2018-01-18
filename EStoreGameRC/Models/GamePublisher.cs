using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("GamesPublishers")]
    public class GamePublisher
    {
            [Key]
        public int GamePublisherID { get; set; }
            [Required(ErrorMessage ="Nazwa wydawcy jest wymagana")]
            [DisplayName("Nazwa wydawcy gry")]
            [StringLength(60)]
            [Column(TypeName ="Wydawca gry")]
        public string NameGamePublisher { get; set; }


        //Wydawca może mieć wiele gier
        public virtual ICollection<Game> Games { get; set; }
    }
}