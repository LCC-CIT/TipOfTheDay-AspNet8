using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TipOfTheDay.Models;

namespace TipOfTheDay.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Seed data
            AppUser appUser = new() { Id = "1", UserName = "A. Member" };
            builder.Entity<AppUser>().HasData(appUser);

            builder.Entity<Tip>().HasData(
                new { TipId = 1, TipText = "The first tip", MemberId = "1" });

            builder.Entity<Tip>().HasData(
                new { TipId = 2, TipText = "Another tip", MemberId = "1" });
            builder.Entity<Tip>().HasData(
                new { TipId = 3, TipText = "Yet another tip", MemberId = "1" });

            Tag tag1 = new() { TagId = 1, Category = "Cat-A" };
            Tag tag2 = new() { TagId = 2, Category = "Cat-B" };
            Tag tag3 = new() { TagId = 3, Category = "Cat-C" };
            builder.Entity<Tag>().HasData(tag1, tag2, tag3);
        }

        public DbSet<Tip> Tip { get; set; }
        public DbSet<Tag> Tag { get; set; }
    }
}