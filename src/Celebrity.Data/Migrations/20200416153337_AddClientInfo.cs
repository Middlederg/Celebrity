using Microsoft.EntityFrameworkCore.Migrations;

namespace Celebrity.Data.Migrations
{
    public partial class AddClientInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientInfo",
                table: "LoadedGames");

            migrationBuilder.AddColumn<string>(
                name: "IpAddress",
                table: "LoadedGames",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserAgent",
                table: "LoadedGames",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IpAddress",
                table: "LoadedGames");

            migrationBuilder.DropColumn(
                name: "UserAgent",
                table: "LoadedGames");

            migrationBuilder.AddColumn<string>(
                name: "ClientInfo",
                table: "LoadedGames",
                type: "TEXT",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
