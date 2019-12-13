using System;
using System.Collections.Generic;
using System.Text;
using IWasThere.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        public DbSet<Location> Location { get; set; }
        public DbSet<UserGame> UserGame { get; set; }

        
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

            
            modelBuilder.Entity<Team>().HasData(
               new Team()
               {
                   UserId = user.Id,
                   TeamId = 1,
                   TeamName = "Alabama",
                   Nickname = "Crimson Tide"
               },

               new Team()
               {
                   UserId = user.Id,
                   TeamId = 2,
                   TeamName = "Auburn",
                   Nickname = "Tigers"
               },

               new Team()
               {
                   UserId = user.Id,
                   TeamId = 3,
                   TeamName = "Tennessee",
                   Nickname = "Volunteers"
               }
            );

            modelBuilder.Entity<Location>().HasData(
               new Location()
               {
                   LocationId = 1,
                   UserId = user.Id,
                   StadiumName = "Bryant-Denny Stadium",
                   City = "Tuscaloosa",
                   State = "Alabama"
               },

               new Location()
               {
                   LocationId = 2,
                   UserId = user.Id,
                   StadiumName = "Neyland Stadium",
                   City = "Knoxville",
                   State = "Tennessee"
               }
            );

            modelBuilder.Entity<Game>().HasData(
               new Game()
               {
                   GameId = 1,
                   UserId = user.Id,
                   GameName = "Camback",
                   Date = new DateTime(11 / 26 / 2010),
                   LocationId = 1,
                   HomeTeamId = 1,
                   HomeScore = 27,
                   AwayTeamId = 2,
                   AwayScore = 28,
               },

               new Game()
               {
                   GameId = 2,
                   UserId = user.Id,
                   GameName = "The Kick 2",
                   Date = new DateTime(10 / 20 / 1990),
                   LocationId = 2,
                   HomeTeamId = 3,
                   HomeScore = 6,
                   AwayTeamId = 1,
                   AwayScore = 9
               }
             );


            modelBuilder.Entity<UserGame>().HasData(
               new UserGame()
               {
                   UserGameId = 1,
                   UserId = "00000000 - ffff - ffff - ffff - ffffffffffff1",
                   GameId = 1,
                   Story = "Roll Damn Tide, Pawwwwl. Sorry 'bout dem trees."
               },

               new UserGame()
               {
                   UserGameId = 2,
                   UserId = "00000000 - ffff - ffff - ffff - ffffffffffff2",
                   GameId = 2,
                   Story = "I shoulda punted on third down more."
               }

            );
        }
            


    }
}
