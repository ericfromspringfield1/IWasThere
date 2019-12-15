using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IWasThere.Migrations
{
    public partial class GameController : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserGame",
                keyColumn: "UserGameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserGame",
                keyColumn: "UserGameId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Location",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "TeamId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9ae786f-fbe0-4ea0-8ae3-f7d0e906d2c2", "AQAAAAEAACcQAAAAEMeWaNbn5rAHmyIlGClRyd9wKonAPJ2vAOtMasbQTNQYDK6fqA3OS0unXuWLdMj5nw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69d5e803-27a2-4584-a1ad-d99e3ef62a7f", "AQAAAAEAACcQAAAAEJrXACRtQ3l4P0to8CgwbKanAb5neuG4hu+z3InSBeOK6TIkJ1r0oGgw/K/d3lfxjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4fec21a4-f25e-410e-87d1-fd2a0f3f5aad", "AQAAAAEAACcQAAAAECLTDpRGkyvy8fwI3WE/tlDbMa8JA9fQMCy6+mS2rzQ5T5GFoo+xLopsqP99ag4YkQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "PasswordHash" },
                values: new object[] { "b1d1abcb-932e-47cc-a377-b60d301bef79", "ApplicationUser", "AQAAAAEAACcQAAAAEKA6tW6VD4sK4Xq0dQ4wxlHUnD6x1+COKsvLoKcbnziXhc//Idt71uKgs5tcoGb4Jw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff1",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "PasswordHash" },
                values: new object[] { "2ba8e196-f99f-4d86-9eb9-1458ca798a54", "ApplicationUser", "AQAAAAEAACcQAAAAEKCafKNIdqV04IRX30jhk1wwaa3vP/AhXe1CgfMyyet+CyB3xB71AOiC2B8uWjFfzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff2",
                columns: new[] { "ConcurrencyStamp", "Discriminator", "PasswordHash" },
                values: new object[] { "d68e39f5-9693-4ea5-b659-3797ad317c2a", "ApplicationUser", "AQAAAAEAACcQAAAAEFxrcZHAszu/6ICBOlZqyg0TH3yRrAlx7rjEv1Zq9Tk3XlLeexPejVi3e6tQ2FSbJQ==" });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "LocationId", "City", "StadiumName", "State", "UserId" },
                values: new object[,]
                {
                    { 1, "Tuscaloosa", "Bryant-Denny Stadium", "Alabama", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, "Knoxville", "Neyland Stadium", "Tennessee", "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamId", "Nickname", "TeamName", "UserId" },
                values: new object[,]
                {
                    { 1, "Crimson Tide", "Alabama", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, "Tigers", "Auburn", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, "Volunteers", "Tennessee", "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "UserGame",
                columns: new[] { "UserGameId", "ApplicationUserId", "GameId", "Story", "UserId" },
                values: new object[,]
                {
                    { 1, null, 1, "Roll Damn Tide, Pawwwwl. Sorry 'bout dem trees.", "00000000 - ffff - ffff - ffff - ffffffffffff1" },
                    { 2, null, 2, "I shoulda punted on third down more.", "00000000 - ffff - ffff - ffff - ffffffffffff2" }
                });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "AwayScore", "AwayTeamId", "Date", "GameName", "HomeScore", "HomeTeamId", "LocationId", "TeamId", "UserId" },
                values: new object[] { 1, 28, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camback", 27, 1, 1, null, "00000000-ffff-ffff-ffff-ffffffffffff" });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "AwayScore", "AwayTeamId", "Date", "GameName", "HomeScore", "HomeTeamId", "LocationId", "TeamId", "UserId" },
                values: new object[] { 2, 9, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Kick 2", 6, 3, 2, null, "00000000-ffff-ffff-ffff-ffffffffffff" });
        }
    }
}
