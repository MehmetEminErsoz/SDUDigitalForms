using Microsoft.EntityFrameworkCore.Migrations;

namespace SduDigitalForm.Data.Migrations
{
    public partial class addForeignKeyToTbl_Issue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Issues_Tbl_IssueTypes_TypeIssueIdissue",
                table: "Tbl_Issues");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Issues_Tbl_TypeDevices_TypeDeviceId",
                table: "Tbl_Issues");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Issues_TypeIssueIdissue",
                table: "Tbl_Issues");

            migrationBuilder.DropColumn(
                name: "TypeIssueIdissue",
                table: "Tbl_Issues");

            migrationBuilder.AlterColumn<int>(
                name: "TypeDeviceId",
                table: "Tbl_Issues",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeIssueId",
                table: "Tbl_Issues",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Issues_TypeIssueId",
                table: "Tbl_Issues",
                column: "TypeIssueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Issues_Tbl_IssueTypes_TypeIssueId",
                table: "Tbl_Issues",
                column: "TypeIssueId",
                principalTable: "Tbl_IssueTypes",
                principalColumn: "Idissue",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Issues_Tbl_TypeDevices_TypeDeviceId",
                table: "Tbl_Issues",
                column: "TypeDeviceId",
                principalTable: "Tbl_TypeDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Issues_Tbl_IssueTypes_TypeIssueId",
                table: "Tbl_Issues");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Issues_Tbl_TypeDevices_TypeDeviceId",
                table: "Tbl_Issues");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Issues_TypeIssueId",
                table: "Tbl_Issues");

            migrationBuilder.DropColumn(
                name: "TypeIssueId",
                table: "Tbl_Issues");

            migrationBuilder.AlterColumn<int>(
                name: "TypeDeviceId",
                table: "Tbl_Issues",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TypeIssueIdissue",
                table: "Tbl_Issues",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Issues_TypeIssueIdissue",
                table: "Tbl_Issues",
                column: "TypeIssueIdissue");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Issues_Tbl_IssueTypes_TypeIssueIdissue",
                table: "Tbl_Issues",
                column: "TypeIssueIdissue",
                principalTable: "Tbl_IssueTypes",
                principalColumn: "Idissue",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Issues_Tbl_TypeDevices_TypeDeviceId",
                table: "Tbl_Issues",
                column: "TypeDeviceId",
                principalTable: "Tbl_TypeDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
