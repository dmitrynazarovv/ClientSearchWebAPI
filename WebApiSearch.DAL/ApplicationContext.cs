using Microsoft.EntityFrameworkCore;
using WebApiSearch.Domain.Models;

namespace WebApiSearch.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
    }
}
