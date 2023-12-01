using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4ee6-a13e-104c439ae888",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2eebb70c-2624-4508-b385-6f6daa8defc7", "AQAAAAIAAYagAAAAEI7qS8RE8joDOId4lIS8yoDKcdINcB2letPL/QWz3JtV1jxxB1RFiyo/rP/3UGEkAw==", "23e98cdf-067a-4356-bc27-0364441b21d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52bc7124-7b0c-4362-b075-598bd709077a", "AQAAAAIAAYagAAAAEChpRb8KwokJ9ZZJGvR6cuMj3N3tMc+pEnqwf+b/m81MJxx48lcyxcZvAqOpGAdnUQ==", "1161774a-49d5-4870-952d-58e70d3417c1" });
        }
    }
}
