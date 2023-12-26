using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TR.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "723f4955-afd7-45b0-97fb-fee25c83d3ad", "AQAAAAIAAYagAAAAEO99G6OW84yyiGwQNuAfk6VqApXD29QfoErOWg3M9oBpaLyq9EeLNCGlLb5m2I2GsQ==", "f9e6edf4-fd1e-45d4-b9d5-c5f85a37055e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c92d0ea-cd9c-4713-a729-8c7a8029dd50", "AQAAAAIAAYagAAAAEKIzRNXxKg7Q5qBn4X7N4RzNMow4nNyZmDIr19Ax8fyFhkGRMegU/WTl/5g9NbFdgg==", "d25312fa-5fff-4326-9f91-637605f4d027" });
        }
    }
}
