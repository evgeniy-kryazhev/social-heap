using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialHeap.Migrations
{
    public partial class set_unique_userId_from_account_profile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AccountProfiles_UserId",
                table: "AccountProfiles",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AccountProfiles_UserId",
                table: "AccountProfiles");
        }
    }
}
