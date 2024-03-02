using Microsoft.EntityFrameworkCore;
using TechnologyKedda.Web.Models;

namespace TechnologyKedda.Web.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }

        public DbSet<People>Peoples { get; set; }
    }
}
