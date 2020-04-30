using Microsoft.EntityFrameworkCore.Migrations;

namespace NRProject.Data.Migrations
{
    public partial class AddingUsernameToJobOffer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserUsername",
                table: "JobOffers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserUsername",
                table: "JobOffers");
        }
    }
}
