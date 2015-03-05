using System.Data.Entity;

namespace AplicacaoComCodeFirst.Models
{
    public class BlogContext : DbContext
    {
        
        //public BlogContext() : base("name=BlogContext")
        /*public BlogContext() : base("name=DefaultConnection")
            
        {
            //Database.Connection.ConnectionString = @"Data Source=mga-baia\localdb";

            //Database.Connection.ConnectionString = @"data source=FABRCIOSANC36FC\SQLEXPRESS;
//initial catalog=BlogBDLivro; Integrated Security=SSPI";
        }*/
         
        public DbSet<Posts> Posts { get; set; }

        public DbSet<Categorias> Categorias { get; set; }
    }
}