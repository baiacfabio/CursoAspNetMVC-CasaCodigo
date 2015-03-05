using System.Data.Entity;

namespace AplicacaoComCodeFirst.Models
{
    public class BlogContext : DbContext
    {
        
        public DbSet<Posts> Posts { get; set; }

        public DbSet<Categorias> Categorias { get; set; }
    }
}