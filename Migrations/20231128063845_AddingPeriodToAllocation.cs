using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddingPeriodToAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4ee6-a13e-104c439ae888",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01542898-aa80-466f-9137-8d14cdcc571a", "AQAAAAIAAYagAAAAELRvStv06NzIo1oI7RP3ajnB1KylMJ3W39rCDnnCKm251hyUnyyzscbIRJkHzAhDVA==", "adbaae5f-9014-451c-8d1b-ab5f4c2701b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "806bf10a-0e08-4e0a-a759-da46b7e542e2", "AQAAAAIAAYagAAAAENcYOdrW4LefWRhO5RFIz5IyuvfB2/6GMazDb32H+SjaCD4PJBXrJ0stnS8xt7u+BQ==", "2e1f8f61-9ad0-4265-8cfa-23dee43d8b77" });
        }
    }
}
