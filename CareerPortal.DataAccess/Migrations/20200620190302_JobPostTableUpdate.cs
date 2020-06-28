using Microsoft.EntityFrameworkCore.Migrations;

namespace CareerPortal.DataAccess.Migrations
{
    public partial class JobPostTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ComponyLogoUrl",
                table: "JobPosts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobPostImageUrl",
                table: "JobPosts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComponyLogoUrl",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "JobPostImageUrl",
                table: "JobPosts");
        }
    }
}
