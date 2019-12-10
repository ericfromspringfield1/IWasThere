using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IWasThere.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<string>(nullable: false),
                    LocationId = table.Column<int>(nullable: false),
                    HomeTeamId = table.Column<int>(nullable: false),
                    HomeScore = table.Column<int>(nullable: false),
                    AwayTeamId = table.Column<int>(nullable: false),
                    AwayScore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Game_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StadiumName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Location_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(nullable: true),
                    Nickname = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Team_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserGame",
                columns: table => new
                {
                    UserGameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: false),
                    Story = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGame", x => x.UserGameId);
                    table.ForeignKey(
                        name: "FK_UserGame_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "fb909f0c-534a-4f41-9099-9e6ab1778eaf", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEN5TU3XWFF4wKJ71nWpgyz9GerwDFEPL7bb4nwfe+4XJccYpVKFZbqGRC9yrC5ii+A==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com", "Admina", "Straytor" },
                    { "00000000-ffff-ffff-ffff-ffffffffffff1", 0, "eac0dd79-d1db-4f38-b202-2130209d209d", "ApplicationUser", "harvey@harvey.com", true, false, null, "HARVEY@HARVEY.COM", "HARVEY@HARVEY.COM", "AQAAAAEAACcQAAAAEDLQrn2Ndh7hfjdaRfvFa057i5Bv86KorjQ0yoPayBIzDZRRVQCj1FeQQC1W3APtpg==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794578", false, "harvey@harvey.com", "Harvey", "Updyke" },
                    { "00000000-ffff-ffff-ffff-ffffffffffff2", 0, "44b20992-9474-4dd3-86da-07e9d76b01ad", "ApplicationUser", "johnny@johnny.com", true, false, null, "JOHNNY@JOHNNY.COM", "JOHNNY@JOHNNY.COM", "AQAAAAEAACcQAAAAEJx0Cr0DSZ2CbF+0zDsoHFBRpJQVHPkt5PSPrcuNOCNUjgKRCZFqU9tX60uYxSHL4g==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794590", false, "johnny@johnny.com", "Johnny", "Majors" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "ApplicationUserId", "City", "StadiumName", "State", "UserId" },
                values: new object[,]
                {
                    { 1, null, "Tuscaloosa", "Bryant-Denny Stadium", "Alabama", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, null, "Knoxville", "Neyland Stadium", "Tennessee", "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "ApplicationUserId", "Nickname", "TeamName", "UserId" },
                values: new object[,]
                {
                    { 1, null, "Crimson Tide", "Alabama", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, null, "Tigers", "Auburn", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, null, "Volunteers", "Tennessee", "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "AwayScore", "AwayTeamId", "Date", "GameName", "HomeScore", "HomeTeamId", "LocationId", "UserId" },
                values: new object[] { 1, 27, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camback", 27, 1, 1, "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "AwayScore", "AwayTeamId", "Date", "GameName", "HomeScore", "HomeTeamId", "LocationId", "UserId" },
                values: new object[] { 2, 9, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Kick 2", 6, 3, 2, "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "UserGame",
                columns: new[] { "UserGameId", "GameId", "Story", "UserId" },
                values: new object[] { 1, 1, "Roll Damn Tide, Pawwwwl. Sorry 'bout dem trees.", "00000000 - ffff - ffff - ffff - ffffffffffff1" });

            migrationBuilder.InsertData(
                table: "UserGame",
                columns: new[] { "UserGameId", "GameId", "Story", "UserId" },
                values: new object[] { 2, 2, "I shoulda punted on third down more.", "00000000 - ffff - ffff - ffff - ffffffffffff2" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Game_UserId",
                table: "Game",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_ApplicationUserId",
                table: "Location",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_ApplicationUserId",
                table: "Team",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGame_GameId",
                table: "UserGame",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "UserGame");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
