using Microsoft.EntityFrameworkCore.Migrations;

namespace promact.Migrations
{
    public partial class value : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "messageID", "likes", "message", "username" },
                values: new object[] { 1, 0, " hello Ironman", "Ironman" });

            migrationBuilder.InsertData(
                table: "Message",
                columns: new[] { "messageID", "likes", "message", "username" },
                values: new object[] { 2, 0, " hellooooo Ironman", "Ironmannnn" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "messageID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Message",
                keyColumn: "messageID",
                keyValue: 2);
        }
    }
}
