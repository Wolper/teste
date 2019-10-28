using Microsoft.EntityFrameworkCore;
using teste.Model;

namespace teste.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}        
        public DbSet<Usuario> Usuarios { get; set; }
    }
}