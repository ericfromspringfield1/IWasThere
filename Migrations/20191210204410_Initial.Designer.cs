﻿// <auto-generated />
using System;
using IWasThere.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IWasThere.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191210204410_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IWasThere.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayScore")
                        .HasColumnType("int");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("GameName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomeScore")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Game");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            AwayScore = 27,
                            AwayTeamId = 2,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GameName = "Camback",
                            HomeScore = 27,
                            HomeTeamId = 1,
                            LocationId = 1,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            GameId = 2,
                            AwayScore = 9,
                            AwayTeamId = 1,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GameName = "The Kick 2",
                            HomeScore = 6,
                            HomeTeamId = 3,
                            LocationId = 2,
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("IWasThere.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StadiumName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            City = "Tuscaloosa",
                            StadiumName = "Bryant-Denny Stadium",
                            State = "Alabama",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            LocationId = 2,
                            City = "Knoxville",
                            StadiumName = "Neyland Stadium",
                            State = "Tennessee",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("IWasThere.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            TeamId = 1,
                            Nickname = "Crimson Tide",
                            TeamName = "Alabama",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            TeamId = 2,
                            Nickname = "Tigers",
                            TeamName = "Auburn",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        },
                        new
                        {
                            TeamId = 3,
                            Nickname = "Volunteers",
                            TeamName = "Tennessee",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff"
                        });
                });

            modelBuilder.Entity("IWasThere.Models.UserGame", b =>
                {
                    b.Property<int>("UserGameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Story")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserGameId");

                    b.HasIndex("GameId");

                    b.ToTable("UserGame");

                    b.HasData(
                        new
                        {
                            UserGameId = 1,
                            GameId = 1,
                            Story = "Roll Damn Tide, Pawwwwl. Sorry 'bout dem trees.",
                            UserId = "00000000 - ffff - ffff - ffff - ffffffffffff1"
                        },
                        new
                        {
                            UserGameId = 2,
                            GameId = 2,
                            Story = "I shoulda punted on third down more.",
                            UserId = "00000000 - ffff - ffff - ffff - ffffffffffff2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("IWasThere.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fb909f0c-534a-4f41-9099-9e6ab1778eaf",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEN5TU3XWFF4wKJ71nWpgyz9GerwDFEPL7bb4nwfe+4XJccYpVKFZbqGRC9yrC5ii+A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com",
                            FirstName = "Admina",
                            LastName = "Straytor"
                        },
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eac0dd79-d1db-4f38-b202-2130209d209d",
                            Email = "harvey@harvey.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "HARVEY@HARVEY.COM",
                            NormalizedUserName = "HARVEY@HARVEY.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDLQrn2Ndh7hfjdaRfvFa057i5Bv86KorjQ0yoPayBIzDZRRVQCj1FeQQC1W3APtpg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794578",
                            TwoFactorEnabled = false,
                            UserName = "harvey@harvey.com",
                            FirstName = "Harvey",
                            LastName = "Updyke"
                        },
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "44b20992-9474-4dd3-86da-07e9d76b01ad",
                            Email = "johnny@johnny.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JOHNNY@JOHNNY.COM",
                            NormalizedUserName = "JOHNNY@JOHNNY.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJx0Cr0DSZ2CbF+0zDsoHFBRpJQVHPkt5PSPrcuNOCNUjgKRCZFqU9tX60uYxSHL4g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794590",
                            TwoFactorEnabled = false,
                            UserName = "johnny@johnny.com",
                            FirstName = "Johnny",
                            LastName = "Majors"
                        });
                });

            modelBuilder.Entity("IWasThere.Models.Game", b =>
                {
                    b.HasOne("IWasThere.Models.ApplicationUser", "User")
                        .WithMany("Games")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IWasThere.Models.Location", b =>
                {
                    b.HasOne("IWasThere.Models.ApplicationUser", null)
                        .WithMany("Locations")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("IWasThere.Models.Team", b =>
                {
                    b.HasOne("IWasThere.Models.ApplicationUser", null)
                        .WithMany("Teams")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("IWasThere.Models.UserGame", b =>
                {
                    b.HasOne("IWasThere.Models.Game", null)
                        .WithMany("UserGames")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
