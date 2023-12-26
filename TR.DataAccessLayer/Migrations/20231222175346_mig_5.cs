using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TR.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneBooks_AspNetUsers_UserId",
                table: "PhoneBooks");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PhoneBooks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d1d5758-ed5f-4cce-974c-0b0a7724cd7a", "AQAAAAIAAYagAAAAEMJEvaTN8YOSNM/kMiKMhLVTBKQJYWXcLYVGDqzj0PSvSQYmbTRgDxOpu3ml17fi7g==", "f748c3f2-7254-42d1-b4a1-4c8a7af95e0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c836145-2f24-47b8-b09c-494167d16d34", "AQAAAAIAAYagAAAAEJ8A8AaGJeyCXKUVevwm4d8Zt4v9QVd28NMwonPMzPlfJdWR4MBztleGPWV8AyJ+fg==", "a5a809f7-670c-457b-908f-58e0b8a765be" });

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneBooks_AspNetUsers_UserId",
                table: "PhoneBooks",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneBooks_AspNetUsers_UserId",
                table: "PhoneBooks");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PhoneBooks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "879ed1f2-e30f-40a1-8bf2-655f41d78aa7", "AQAAAAIAAYagAAAAEA/iUHaVxoak9t0DUQHAGQkmFLdbCDYNKLBNNawGSnFLlz+5e1yX5bpO4BeUXop0JQ==", "505b2e42-a400-42eb-a606-524754da5c29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3457a391-c1f4-4dcb-ace3-7913ba9e430e", "AQAAAAIAAYagAAAAED+3lF7dCUX28b9Fsr7QId64iv6Ny5aqh/6LP9rCnHYnU1zK2unByFFLzKWYZ/g9pg==", "c1603082-bd6f-4a51-87eb-4a2d2808b740" });

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneBooks_AspNetUsers_UserId",
                table: "PhoneBooks",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
