using Microsoft.EntityFrameworkCore.Migrations;

namespace promact.Migrations
{
    public partial class re : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "commentID",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "shareID",
                table: "Message");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "commentID",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "shareID",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
