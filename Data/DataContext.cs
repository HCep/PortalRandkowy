using Microsoft.EntityFrameworkCore;
using PortalRandkowy.Api.Models;
namespace PortalRandkowy.Api.Data {

    public class DataContext : DbContext {
        public DataContext (DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Value> Values { get; set; }
    }
}