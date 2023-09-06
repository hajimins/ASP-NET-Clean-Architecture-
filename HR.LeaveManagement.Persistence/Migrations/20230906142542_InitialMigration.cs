using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR.LeaveManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 9, 6, 18, 25, 42, 655, DateTimeKind.Local).AddTicks(9728), new DateTime(2023, 9, 6, 18, 25, 42, 655, DateTimeKind.Local).AddTicks(9742) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LeaveTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 9, 6, 18, 19, 10, 616, DateTimeKind.Local).AddTicks(3079), new DateTime(2023, 9, 6, 18, 19, 10, 616, DateTimeKind.Local).AddTicks(3095) });
        }
    }
}
