using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyPics.Migrations
{
    public partial class FamilyPicsUpdateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "FirstName", "Password", "UserName" },
                values: new object[] { 1, "Chris", null, "ChrisBHammond" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "FirstName", "Password", "UserName" },
                values: new object[] { 2, "Bonnie", null, "BonnieBHammond" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
