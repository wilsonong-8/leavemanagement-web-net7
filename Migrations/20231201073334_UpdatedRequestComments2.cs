using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4ee6-a13e-104c439ae888",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d91bb8f8-a803-4571-9663-302c8c2cebfc", "AQAAAAIAAYagAAAAEBoOzpnx+X5YQSLvjBVH1/2UBoahmyrH6vc5jgqY6XtEj8y9h3AgR2/X73es8WHE/w==", "6acc032e-029e-4f6f-8fa9-399cdc3f1cd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b4cb5c7-f859-4891-8c89-74442694e6ab", "AQAAAAIAAYagAAAAECVNqAyNnC4t5ZIQHJ4ZOBsE6yDiDrPozu/gdulEO32GXdQRiprc1u8WhfuT7yjTAA==", "d319f956-2caa-4a8d-9b42-ce9e3470a361" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4ee6-a13e-104c439ae888",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2293fbe3-7f47-4742-943f-3b244413f143", "AQAAAAIAAYagAAAAEOuW8BIDqqN0jHFOGeNXoSRUI4kWx4DTNgnK1N+Lo5V4V9HiWurwimD/AiOVK0DoOQ==", "e4b7042c-adc4-4239-a906-3d5f26137912" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e3795b7-c7e4-4bef-9132-028c21fcb9b6", "AQAAAAIAAYagAAAAEBa1vencLkiYrIh1uP1+pmaCtcEZ/iJ4VOKxe9ZaOUqFEBbhRD3frnxnbpXGe/U7MA==", "2cc1a969-8e4c-4c28-aead-6bf2152a7889" });
        }
    }
}
