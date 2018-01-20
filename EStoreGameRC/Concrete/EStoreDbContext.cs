namespace EStoreGameRC.Concrete
{
    using EStoreGameRC.Models;
    using System.Collections.Generic;
    using System.Web;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EStoreDbContext : DbContext
    {
        public EStoreDbContext()
            : base("name=EStoreDbContext")
        {
        }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Copie> Copies { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameLanguage> GamesLanguages { get; set; }
        public DbSet<GamePublisher> GamesPublishers { get; set; }
        public DbSet<GameType> GamesTypes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<PlatformType> PlatformsTypes { get; set; }
        public DbSet<SalesInvoice> SalesInvoices { get; set; }
        public DbSet<State> SystemRequirs { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<WishList> WishesLists { get; set; }

    }

}