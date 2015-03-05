using System.Data.Entity;
using System.Runtime.ConstrainedExecution;

namespace AplicacaoComCodeFirst.Models
{
    public class BlogContext : DbContext
    {
        
        public DbSet<Posts> Posts { get; set; }

        public DbSet<Categorias> Categorias { get; set; }

        public DbSet<Tags> Tags { get; set; }

    }
}