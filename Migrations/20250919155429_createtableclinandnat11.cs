using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_DoList_AspMVC.Migrations
{
    /// <inheritdoc />
    public partial class createtableclinandnat11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "TodoTasks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TodoTasks_CategoryId",
                table: "TodoTasks",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoTasks_Categories_CategoryId",
                table: "TodoTasks",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TodoTasks_Categories_CategoryId",
                table: "TodoTasks");

            migrationBuilder.DropIndex(
                name: "IX_TodoTasks_CategoryId",
                table: "TodoTasks");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "TodoTasks");
        }
    }
}
