using Microsoft.EntityFrameworkCore.Migrations;

namespace SduDigitalForm.Data.Migrations
{
    public partial class UpdateDBmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeIssueId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TypeIssueId",
                table: "AspNetUsers",
                column: "TypeIssueId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Tbl_OrganizationUnits_TypeIssueId",
                table: "AspNetUsers",
                column: "TypeIssueId",
                principalTable: "Tbl_OrganizationUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Tbl_OrganizationUnits_TypeIssueId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TypeIssueId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TypeIssueId",
                table: "AspNetUsers");
        }
    }
}
