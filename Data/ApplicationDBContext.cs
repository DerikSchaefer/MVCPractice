using Microsoft.EntityFrameworkCore;

using Udemy1.Models;

namespace Udemy1.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }


    }
}

