using Microsoft.EntityFrameworkCore.Migrations;

namespace NRProject.Data.Migrations
{
    public partial class AnotherFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffers_AspNetUsers_ApplicationUserId",
                table: "JobOffers");

            migrationBuilder.DropIndex(
                name: "IX_JobOffers_ApplicationUserId",
                table: "JobOffers");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "JobOffers");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "JobOffers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_UserId",
                table: "JobOffers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffers_AspNetUsers_UserId",
                table: "JobOffers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobOffers_AspNetUsers_UserId",
                table: "JobOffers");

            migrationBuilder.DropIndex(
                name: "IX_JobOffers_UserId",
                table: "JobOffers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "JobOffers");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "JobOffers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobOffers_ApplicationUserId",
                table: "JobOffers",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobOffers_AspNetUsers_ApplicationUserId",
                table: "JobOffers",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
