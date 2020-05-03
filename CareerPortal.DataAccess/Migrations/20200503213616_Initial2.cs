using Microsoft.EntityFrameworkCore.Migrations;

namespace CareerPortal.DataAccess.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_JobPosts_CountryId",
                table: "JobPosts",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobPosts_Countries_CountryId",
                table: "JobPosts",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPosts_Countries_CountryId",
                table: "JobPosts");

            migrationBuilder.DropIndex(
                name: "IX_JobPosts_CountryId",
                table: "JobPosts");
        }
    }
}
