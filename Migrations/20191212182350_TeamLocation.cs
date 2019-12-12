using Microsoft.EntityFrameworkCore.Migrations;

namespace IWasThere.Migrations
{
    public partial class TeamLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Team_TeamId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_AspNetUsers_ApplicationUserId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_ApplicationUserId",
                table: "Location");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Location");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Location",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Game",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b1d1abcb-932e-47cc-a377-b60d301bef79", "AQAAAAEAACcQAAAAEKA6tW6VD4sK4Xq0dQ4wxlHUnD6x1+COKsvLoKcbnziXhc//Idt71uKgs5tcoGb4Jw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ba8e196-f99f-4d86-9eb9-1458ca798a54", "AQAAAAEAACcQAAAAEKCafKNIdqV04IRX30jhk1wwaa3vP/AhXe1CgfMyyet+CyB3xB71AOiC2B8uWjFfzw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d68e39f5-9693-4ea5-b659-3797ad317c2a", "AQAAAAEAACcQAAAAEFxrcZHAszu/6ICBOlZqyg0TH3yRrAlx7rjEv1Zq9Tk3XlLeexPejVi3e6tQ2FSbJQ==" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "TeamId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "TeamId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Location_UserId",
                table: "Location",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Team_TeamId",
                table: "Game",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_AspNetUsers_UserId",
                table: "Location",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_Team_TeamId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_AspNetUsers_UserId",
                table: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Location_UserId",
                table: "Location");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Location",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Location",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Game",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e64da7f0-20f8-49b4-a7b3-88d994dadfce", "AQAAAAEAACcQAAAAEIcD/BsTgxKyCbbzu3+j+gti34ZJCWw2Ork5ec2g0OYYarpAbsG6zIZBQ0DUJKss5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ae71544-f189-4070-8448-c96487079597", "AQAAAAEAACcQAAAAEE9X61zcp4dyzNiIRgraqMIUfSF0Pwua/w17non08d4Z1P/uofNc7L9QSeU7RlhRSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9552c1c4-bde8-41cd-9707-21f6898f4686", "AQAAAAEAACcQAAAAEO9t6bpTPpabWaAdR5LkXRYHhlZ4BV7Y2e0pxJ6dFYTZB/3LpoWm4WazxVLAqDkBMQ==" });

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 1,
                column: "TeamId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: 2,
                column: "TeamId",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Location_ApplicationUserId",
                table: "Location",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_Team_TeamId",
                table: "Game",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_AspNetUsers_ApplicationUserId",
                table: "Location",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
