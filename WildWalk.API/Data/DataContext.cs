using Microsoft.EntityFrameworkCore;
using WildWalk.API.Models;

namespace WildWalk.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
    }
}