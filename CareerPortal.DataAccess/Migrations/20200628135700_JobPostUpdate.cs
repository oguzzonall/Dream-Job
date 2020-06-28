using Microsoft.EntityFrameworkCore.Migrations;

namespace CareerPortal.DataAccess.Migrations
{
    public partial class JobPostUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JobPostImageUrl",
                table: "JobPosts",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ComponyLogoUrl",
                table: "JobPosts",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FacebookUrl",
                table: "JobPosts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedinUrl",
                table: "JobPosts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TwitterUrl",
                table: "JobPosts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebSiteUrl",
                table: "JobPosts",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacebookUrl",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "LinkedinUrl",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "TwitterUrl",
                table: "JobPosts");

            migrationBuilder.DropColumn(
                name: "WebSiteUrl",
                table: "JobPosts");

            migrationBuilder.AlterColumn<string>(
                name: "JobPostImageUrl",
                table: "JobPosts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ComponyLogoUrl",
                table: "JobPosts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
