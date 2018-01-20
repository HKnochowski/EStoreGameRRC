using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EStoreGameRC.Models
{
    public class EStoreGameRCContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EStoreGameRCContext() : base("name=EStoreGameRCContext")
        {
        }

        public System.Data.Entity.DbSet<EStoreGameRC.Models.Employer> Employers { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.Address> Addresses { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.Contact> Contacts { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.Basket> Baskets { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.Client> Clients { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.Copie> Copies { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.Gallery> Gallerys { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.Game> Games { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.GameLanguage> GameLanguages { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.GamePublisher> GamePublishers { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.GameType> GameTypes { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.Image> Images { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.Platform> Platforms { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.PlatformType> PlatformTypes { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.SalesInvoice> SalesInvoices { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.SystemRequir> SystemRequirs { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.Video> Videos { get; set; }
        public System.Data.Entity.DbSet<EStoreGameRC.Models.WishList> WishesLists { get; set; }
    }
}
