using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TR.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "PhoneBooks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CreateName",
                table: "PhoneBooks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "723f4955-afd7-45b0-97fb-fee25c83d3ad", "ramazan.yaylali@gmail.com", false, false, null, "Ramazan", "RAMAZAN.YAYLALI@GMAİL.COM", "RAMAZANY", "AQAAAAIAAYagAAAAEO99G6OW84yyiGwQNuAfk6VqApXD29QfoErOWg3M9oBpaLyq9EeLNCGlLb5m2I2GsQ==", null, false, "f9e6edf4-fd1e-45d4-b9d5-c5f85a37055e", false, "RamazanY" },
                    { 2, 0, "1c92d0ea-cd9c-4713-a729-8c7a8029dd50", "ahmet.yaylali@gmail.com", false, false, null, "Ahmet", "AHMET.YAYLALI@GMAİL.COM", "AHMETY", "AQAAAAIAAYagAAAAEKIzRNXxKg7Q5qBn4X7N4RzNMow4nNyZmDIr19Ax8fyFhkGRMegU/WTl/5g9NbFdgg==", null, false, "d25312fa-5fff-4326-9f91-637605f4d027", false, "AhmetY" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "PhoneBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreateName",
                table: "PhoneBooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
