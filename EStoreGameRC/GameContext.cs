namespace EStoreGameRC
{
    using EStoreGameRC.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class GameContext : DbContext
    {
        
        public GameContext()
            : base("name=GameContext")
        {
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameType> GamesTypes { get; set; }

       
    }

    
}