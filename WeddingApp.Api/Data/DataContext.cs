using Microsoft.EntityFrameworkCore;
using WeddingApp.Api.Models;

namespace WeddingApp.Api.Data {
    public class DataContext : DbContext {
        public DataContext (DbContextOptions<DataContext> Option) : base (Option) {

        }

        public DbSet<Models.Value> Values { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
    }
}