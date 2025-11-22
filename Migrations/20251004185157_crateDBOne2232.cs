using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_DoList_AspMVC.Migrations
{
    /// <inheritdoc />
    public partial class crateDBOne2232 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "TodoTasks",
                newName: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_TodoTasks_PriorityId",
                table: "TodoTasks",
                column: "PriorityId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoTasks_Priorities_PriorityId",
                table: "TodoTasks",
                column: "PriorityId",
                principalTable: "Priorities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoTasks_Priorities_PriorityId",
                table: "TodoTasks");

            migrationBuilder.DropIndex(
                name: "IX_TodoTasks_PriorityId",
                table: "TodoTasks");

            migrationBuilder.RenameColumn(
                name: "PriorityId",
                table: "TodoTasks",
                newName: "Priority");
        }
    }
}
