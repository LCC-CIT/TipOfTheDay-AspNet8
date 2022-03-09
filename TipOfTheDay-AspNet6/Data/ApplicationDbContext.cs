using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TipOfTheDay.Models;

namespace TipOfTheDay_AspNet6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TipOfTheDay.Models.Tip> Tip { get; set; }
        public DbSet<TipOfTheDay.Models.Tag> Tag { get; set; }
    }
}