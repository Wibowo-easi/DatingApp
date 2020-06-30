using Microsoft.EntityFrameworkCore;
using DATINGAPP.Models;

namespace DATINGAPP.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
    
        public DbSet<Value> Values { get; set; }
    }
}