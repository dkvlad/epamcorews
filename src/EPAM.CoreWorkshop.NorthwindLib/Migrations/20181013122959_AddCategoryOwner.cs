using Microsoft.EntityFrameworkCore.Migrations;

namespace EPAM.CoreWorkshop.NorthwindLib.Migrations
{
    public partial class AddCategoryOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Categories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Categories");
        }
    }
}
