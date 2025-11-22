using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_DoList_AspMVC.Migrations
{
    /// <inheritdoc />
    public partial class crateDBOne22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyTask_Categories_CategoryId",
                table: "MyTask");

            migrationBuilder.DropForeignKey(
                name: "FK_MyTask_Clients_ClientId",
                table: "MyTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyTask",
                table: "MyTask");

            migrationBuilder.RenameTable(
                name: "MyTask",
                newName: "TodoTasks");

            migrationBuilder.RenameIndex(
                name: "IX_MyTask_ClientId",
                table: "TodoTasks",
                newName: "IX_TodoTasks_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_MyTask_CategoryId",
                table: "TodoTasks",
                newName: "IX_TodoTasks_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TodoTasks",
                table: "TodoTasks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoTasks_Categories_CategoryId",
                table: "TodoTasks",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoTasks_Clients_ClientId",
                table: "TodoTasks",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoTasks_Categories_CategoryId",
                table: "TodoTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoTasks_Clients_ClientId",
                table: "TodoTasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TodoTasks",
                table: "TodoTasks");

            migrationBuilder.RenameTable(
                name: "TodoTasks",
                newName: "MyTask");

            migrationBuilder.RenameIndex(
                name: "IX_TodoTasks_ClientId",
                table: "MyTask",
                newName: "IX_MyTask_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_TodoTasks_CategoryId",
                table: "MyTask",
                newName: "IX_MyTask_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyTask",
                table: "MyTask",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyTask_Categories_CategoryId",
                table: "MyTask",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyTask_Clients_ClientId",
                table: "MyTask",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
