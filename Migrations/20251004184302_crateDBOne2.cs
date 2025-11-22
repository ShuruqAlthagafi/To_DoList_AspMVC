using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace To_DoList_AspMVC.Migrations
{
    /// <inheritdoc />
    public partial class crateDBOne2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "Gender", "Name", "NationalityId", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "shuruq@example.com", "Female", "Shuruq Althagafi", 1, "123456", "0501234567" },
                    { 2, "omar@example.com", "Male", "Omar Hassan", 2, "omarpass", "0109876543" },
                    { 3, "laila@example.com", "Female", "Laila Al-Kuwaiti", 4, "laila2025", "96550011223" },
                    { 4, "ahmed@example.com", "Male", "Ahmed Al Ameri", 5, "ahmed@123", "97150111222" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
