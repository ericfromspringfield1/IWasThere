using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using IWasThere.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace IWasThere.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Team> HomeTeam { get; set; }
        public DbSet<Team> AwayTeam { get; set; }
        public DbSet<Location> Location { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);


            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Teams)
                .WithOne(t => t.User)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Games)
                .WithOne(t => t.User)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ApplicationUser>()
               .HasMany(u => u.Locations)
               .WithOne(t => t.User)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>()
                    .HasOne(g => g.HomeTeam)
                    .WithMany(t => t.HomeGames)
                    .HasForeignKey(g => g.HomeTeamId)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>()
                    .HasOne(g => g.AwayTeam)
                    .WithMany(t => t.AwayGames)
                    .HasForeignKey(g => g.AwayTeamId)
                    .OnDelete(DeleteBehavior.Restrict);

           /* modelBuilder.Entity<Game>()
                    .HasOne(g => g.Location)
                    .WithMany(l => l.HomeGames)
                    .HasForeignKey(g => g.HomeTeamId)
                    .OnDelete(DeleteBehavior.Restrict);*/




            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Admina",
                LastName = "Straytor",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };

        var passwordHash = new PasswordHasher<ApplicationUser>();
        user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
        modelBuilder.Entity<ApplicationUser>().HasData(user);

            ApplicationUser harvey = new ApplicationUser
            {
                FirstName = "Harvey",
                LastName = "Updyke",
                UserName = "harvey@harvey.com",
                NormalizedUserName = "HARVEY@HARVEY.COM",
                Email = "harvey@harvey.com",
                NormalizedEmail = "HARVEY@HARVEY.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794578",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff1"
            };
            harvey.PasswordHash = passwordHash.HashPassword(harvey, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(harvey);

            ApplicationUser johnny = new ApplicationUser
            {
                FirstName = "Johnny",
                LastName = "Majors",
                UserName = "johnny@johnny.com",
                NormalizedUserName = "JOHNNY@JOHNNY.COM",
                Email = "johnny@johnny.com",
                NormalizedEmail = "JOHNNY@JOHNNY.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794590",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff2"
            };
            johnny.PasswordHash = passwordHash.HashPassword(johnny, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(johnny);
            
        }

    }
}
