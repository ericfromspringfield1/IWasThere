using Microsoft.EntityFrameworkCore.Migrations;

namespace IWasThere.Migrations
{
    public partial class LocationFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Location_HomeTeamId",
                table: "Game");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb08bd20-ae46-44f7-944e-53bd14250a29", "AQAAAAEAACcQAAAAEGgWPWIx1+1gmECGiqaiVPm1OjNksAYWzcUIkLasZFgVSFtwON3Kohggz7vWAIf5Rw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce6449a4-baed-4586-80e4-7bc857359603", "AQAAAAEAACcQAAAAEOgvDg6wq6k6dKIn1DQfju00vepAQ/+cJgQ6P6EgzT5kehvmT+Q+F74dLChHkABH0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "486b5865-edee-4394-8780-480b92211531", "AQAAAAEAACcQAAAAEJMFlyA+gLr8M49ol8izB3fBAKtmwMivHBkEY6+0YFsNAFghdlmxh09flQ46fmC7/w==" });

            migrationBuilder.CreateIndex(
                name: "IX_Game_LocationId",
                table: "Game",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Location_LocationId",
                table: "Game",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Location_LocationId",
                table: "Game");

            migrationBuilder.DropIndex(
                name: "IX_Game_LocationId",
                table: "Game");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cb16eac-7096-44ca-86ff-0f7a09e34f4f", "AQAAAAEAACcQAAAAEHUY3PDo1i9wtyKypLum8lBMuRQ7yEHaUlITG59MrKmmnS5yEl9NiOUeZE/fgG4tfw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3345a209-f10d-41b0-aae3-7a236733db6c", "AQAAAAEAACcQAAAAEKQ1q8CpKcoqRyT4OyDYNTXiEp/QT8udo5WE5NlNOIQ+ETIVDbF4s0y2WzWajwtdQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "175823a3-a0e2-4343-97c5-51d0847bc825", "AQAAAAEAACcQAAAAECnqFWY9HzGVkqpxTy1Yi7YGeBwHzwUunBMVZLsZqGvB8vfSSwPOg+0zG1byjPz8MA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Location_HomeTeamId",
                table: "Game",
                column: "HomeTeamId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
