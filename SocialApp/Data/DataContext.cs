using Microsoft.EntityFrameworkCore;
using SocialApp.Models;

namespace SocialApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Value> Values { get; set; }
    }
}