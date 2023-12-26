using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TR.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fae9a1aa-a653-43e5-9f2e-1c702aa1e00f", "AQAAAAIAAYagAAAAEJlwAaQ++RnINdsb4+d5fremWW0yC7xdNZ6T4GTMKHD3QC3O9PYWmvQcSpjz/X8Z5w==", "40475fc7-c5d3-4e75-97e4-2e2bf4d3d831" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea606f33-217a-4774-bac4-a428bda462ea", "AQAAAAIAAYagAAAAEAXF/ga11utWVQJZCu6+HOX8lzaLWZEULpvAUaal0lqntR2ilOXfFrilgkuvuEazOg==", "1418141b-e672-4d17-ae47-8d4167249e6b" });
        }
    }
}
