using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("GamePublisher")]
    public class GamePublisher
    {
        [Key]
        public int IDGamePublisher { get; set; }
        public string NameGamePublisher { get; set; }

        //Wydawca może mieć wiele gier
        public virtual ICollection<Game> Games { get; set; }
    }
}