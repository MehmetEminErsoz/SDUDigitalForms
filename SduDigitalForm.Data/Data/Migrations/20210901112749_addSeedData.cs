using Microsoft.EntityFrameworkCore.Migrations;

namespace SduDigitalForm.Data.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tbl_IssueTypes",
                columns: new[] { "Idissue", "IssueType" },
                values: new object[] { 1, "Ekran değişimi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tbl_IssueTypes",
                keyColumn: "Idissue",
                keyValue: 1);
        }
    }
}
