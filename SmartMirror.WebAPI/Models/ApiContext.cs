using Microsoft.EntityFrameworkCore;

namespace SmartMirror.WebAPI.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base (options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Widget> Widgets { get; set; }
        public DbSet<Server> Servers { get; set; }

    }
}
