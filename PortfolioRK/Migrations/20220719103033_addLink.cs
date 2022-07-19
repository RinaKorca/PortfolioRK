using Microsoft.EntityFrameworkCore.Migrations;

namespace PortfolioRK.Migrations
{
    public partial class addLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReloLink",
                table: "Repositories",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReloLink",
                table: "Repositories");
        }
    }
}
