using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    [Table("WishList")]
    public class WishList
    {
        public WishList()
        {
            this.Games = new HashSet<Game>();
        }

        [Key]
        public int WishListID { get; set; }
        public int CodeWishList { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}