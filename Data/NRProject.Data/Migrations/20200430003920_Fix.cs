using Microsoft.EntityFrameworkCore.Migrations;

namespace NRProject.Data.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserUsername",
                table: "JobOffers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserUsername",
                table: "JobOffers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
