using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_DoList_AspMVC.Migrations
{
    /// <inheritdoc />
    public partial class addalltables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "TodoTasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "Priorities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "Nationalities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Uid",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: "ca47c232-daea-45dc-bc70-07712f169a03");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: "e43db725-a6db-4997-ba2d-a4d10b8440e9");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: "81b15507-d156-4cc8-90bc-f92ef5d1f52f");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uid",
                value: "7fde4252-6c9b-42f9-ae05-9ec78d1ac324");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "Uid",
                value: "62be4b81-76d3-4b00-b09a-48c6b31dcda0");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: "a98aad45-f923-4a74-96df-996f449466c7");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: "f4450d96-4f11-4d2b-8f99-5d6973a70027");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: "3e859474-8191-41ba-86fd-422789e401c5");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uid",
                value: "f6539f79-56a7-402c-8409-77139f7f8dff");

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: "4bd50ad5-8135-4957-9ac5-fc4cae657a26");

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: "ae70a897-5a5e-4393-bb06-fc955133fee1");

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: "dddcf483-e78d-4469-8d72-77e246aaefef");

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 4,
                column: "Uid",
                value: "aaec04f9-7724-46e0-99ab-32f05323c8df");

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Uid",
                value: "23d702c8-f3d3-41ba-ac3b-ad3195336468");

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Uid",
                value: "3d054632-a8f0-4357-9630-05cb1c40719d");

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Uid",
                value: "a4bdd626-2dc7-4e66-a65b-bd14854aa25f");

            migrationBuilder.UpdateData(
                table: "Nationalities",
                keyColumn: "Id",
                keyValue: 8,
                column: "Uid",
                value: "cfc7487f-0c87-4ed4-8235-9d7a0a93234d");

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: "d3d55c22-73a1-45dc-a53f-a8cd7736496c");

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: "72420a79-27d8-4e8e-bac2-b6b1f0fcf13f");

            migrationBuilder.UpdateData(
                table: "Priorities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Uid",
                value: "91a5230f-8c3d-4aa6-9602-1f1d1638c8ee");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uid",
                table: "TodoTasks");

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Priorities");

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Nationalities");

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Uid",
                table: "Categories");
        }
    }
}
