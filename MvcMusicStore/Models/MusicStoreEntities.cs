using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class MusicStoreEntities : DbContext, IMusicStoreEntities
    {
        public MusicStoreEntities()
        {
            var connectionstringFromEnvironment = System.Environment.GetEnvironmentVariable(this.GetType().Name);
            if (!string.IsNullOrEmpty(connectionstringFromEnvironment))
            {
                this.Database.Connection.ConnectionString = connectionstringFromEnvironment;
            }
        }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<FeatureToggle> FeatureToggles { get; set; }
        // New DB Schema
        // Feature flag, set in context initializer
        public static bool IsDBSchemaAlreadyAvailable { get; set; }
        //public virtual DbSet<Product> Products { get; set; }
        //public virtual DbSet<ProductCategory> Categories { get; set; }


    }
}