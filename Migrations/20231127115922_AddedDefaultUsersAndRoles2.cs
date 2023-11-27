using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4ee6-a13e-104c439ae888",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "01542898-aa80-466f-9137-8d14cdcc571a", true, "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAELRvStv06NzIo1oI7RP3ajnB1KylMJ3W39rCDnnCKm251hyUnyyzscbIRJkHzAhDVA==", "adbaae5f-9014-451c-8d1b-ab5f4c2701b0", "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11968",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "806bf10a-0e08-4e0a-a759-da46b7e542e2", true, "USER@GMAIL.COM", "AQAAAAIAAYagAAAAENcYOdrW4LefWRhO5RFIz5IyuvfB2/6GMazDb32H+SjaCD4PJBXrJ0stnS8xt7u+BQ==", "2e1f8f61-9ad0-4265-8cfa-23dee43d8b77", "user@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4ee6-a13e-104c439ae888",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7fac0ffc-6159-4487-9c13-6a2e75036498", false, null, "AQAAAAIAAYagAAAAEMf9Pi9TZcxU0gPpaIvT+1cg191/SHd8MLjpaIoKiCNMrVhVMbpDqawlyVhcx/8Bzg==", "fb672980-fddb-4003-aeba-1fc9a123c0b3", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11968",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "463ee51b-9958-4ce8-a782-5c9904205101", false, null, "AQAAAAIAAYagAAAAEEm/X5CspqFA3+3AAlDmx9pdaY4aHIYTUcY6U7RtR2Wgt/nKwImj9FyYseVZnW2IGQ==", "14d7dc13-e646-40a3-846d-3d350edfcc0b", null });
        }
    }
}
