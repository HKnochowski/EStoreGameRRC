using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("WishLists")]
    public class WishList
    {
       /* public WishList()
        {
            this.Games = new HashSet<Game>();
        }   */

            [Key]
        public int WishListID { get; set; }
            [Required(ErrorMessage = "Kod Referencyjny Listy życzeń jest obowiązkowy")]
            [DisplayName("Kod Referencyjny Listy Życzeń")]
            [Column(TypeName ="Lista Życzeń")]
        public int CodeWishList { get; set; }

        public virtual ICollection<Game> Games { get; set; }
        public virtual Client Client { get; set; }
    }
}