using Microsoft.EntityFrameworkCore.Migrations;

namespace BugTracker.Migrations
{
    public partial class AddingStatusInBugEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusName",
                table: "Statuses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "StatusBool",
                table: "Statuses",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Statuses",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Bugs",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Bugs_StatusId",
                table: "Bugs",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Statuses_StatusId",
                table: "Bugs",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Statuses_StatusId",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_StatusId",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Bugs");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Statuses",
                newName: "StatusName");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Statuses",
                newName: "StatusBool");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Statuses",
                newName: "StatusId");
        }
    }
}
