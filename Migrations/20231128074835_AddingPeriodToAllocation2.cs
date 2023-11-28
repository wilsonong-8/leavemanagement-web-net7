using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodToAllocation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NumberOfDays",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4ee6-a13e-104c439ae888",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42d8f3c0-9977-4f27-bf34-2199971fff20", "AQAAAAIAAYagAAAAEGE7A6qrEm2bsMWjV6ZIb0IAoVdF4CWqEbv6oKUeBSDBCXekSPfZnl6VWAZSQPxd8Q==", "2c854066-3fc2-4995-b163-3ff5581bb058" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91e6db27-fe79-4f10-aa3a-693b08d76d4b", "AQAAAAIAAYagAAAAEPJ6FdEqm8BzzdK5u6WtaBBnzAtK7HCctWbq1+8bDgpI/OlXZ4Kx9X2ntyFvaU3N3w==", "ba8e56d4-12dc-4dfe-ade3-bcfbd7ea8dc4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.AlterColumn<string>(
                name: "NumberOfDays",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4ee6-a13e-104c439ae888",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9104faef-46c0-4df0-89a0-ed612c9ce864", "AQAAAAIAAYagAAAAEK2//NsZOe1FvS2AxJzY0qHfwpsc/QgdqfbHM3ey7clzersyqQsyBwKT8eiy+nqi3Q==", "bec82117-b93f-4f33-aac8-f47cfc577052" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "066759a2-602e-46b4-82db-268cac9faf01", "AQAAAAIAAYagAAAAECx/ZdBoe14nrLCLeAjVPKcvcW8FxLwqgqiu7k2kTspNUPEcUd4K9BeYy6h6HsJF/Q==", "9b3a580c-152c-45ee-b893-19f865792dac" });
        }
    }
}
