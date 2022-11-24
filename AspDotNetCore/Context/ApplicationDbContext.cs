using AspDotNetCore.Model;
using Microsoft.EntityFrameworkCore;
namespace AspDotNetCore.Context
   
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }

        public DbSet<PlayerModel> postPlayerModel { get; set; }
            
}
    }

