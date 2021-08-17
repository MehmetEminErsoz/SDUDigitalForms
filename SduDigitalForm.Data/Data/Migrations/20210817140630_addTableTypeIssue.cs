using Microsoft.EntityFrameworkCore.Migrations;

namespace SduDigitalForm.Data.Migrations
{
    public partial class addTableTypeIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_IssueTypes",
                columns: table => new
                {
                    Idissue = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_IssueTypes", x => x.Idissue);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_IssueTypes");
        }
    }
}
