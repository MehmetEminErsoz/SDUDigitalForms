using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SduDigitalForm.Data.Migrations
{
    public partial class addNewTableIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Issues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TypeIssueIdissue = table.Column<int>(type: "int", nullable: true),
                    RepairCustomer = table.Column<int>(type: "int", nullable: false),
                    Delivered = table.Column<int>(type: "int", nullable: false),
                    Giver = table.Column<int>(type: "int", nullable: false),
                    TypeDeviceId = table.Column<int>(type: "int", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RepairDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Issues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Issues_Tbl_IssueTypes_TypeIssueIdissue",
                        column: x => x.TypeIssueIdissue,
                        principalTable: "Tbl_IssueTypes",
                        principalColumn: "Idissue",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Issues_Tbl_TypeDevices_TypeDeviceId",
                        column: x => x.TypeDeviceId,
                        principalTable: "Tbl_TypeDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Issues_TypeDeviceId",
                table: "Tbl_Issues",
                column: "TypeDeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Issues_TypeIssueIdissue",
                table: "Tbl_Issues",
                column: "TypeIssueIdissue");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Issues");
        }
    }
}
