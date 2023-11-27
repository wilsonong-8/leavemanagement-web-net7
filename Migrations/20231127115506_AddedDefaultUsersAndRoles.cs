using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69d10e4c-0427-4448-a13e-104c439ae422", null, "Administrator", "ADMINISTRATOR" },
                    { "69d10e4c-0427-4ee6-a13e-104c439aebba", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "69d10e4c-0427-4ee6-a13e-104c439ae888", 0, "7fac0ffc-6159-4487-9c13-6a2e75036498", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", false, "System", "Admin", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAIAAYagAAAAEMf9Pi9TZcxU0gPpaIvT+1cg191/SHd8MLjpaIoKiCNMrVhVMbpDqawlyVhcx/8Bzg==", null, false, "fb672980-fddb-4003-aeba-1fc9a123c0b3", null, false, null },
                    { "f536c75a-a460-4ecb-a949-58305ba11968", 0, "463ee51b-9958-4ce8-a782-5c9904205101", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", false, "System", "User", false, null, "USER@GMAIL.COM", null, "AQAAAAIAAYagAAAAEEm/X5CspqFA3+3AAlDmx9pdaY4aHIYTUcY6U7RtR2Wgt/nKwImj9FyYseVZnW2IGQ==", null, false, "14d7dc13-e646-40a3-846d-3d350edfcc0b", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "69d10e4c-0427-4448-a13e-104c439ae422", "69d10e4c-0427-4ee6-a13e-104c439ae888" },
                    { "69d10e4c-0427-4ee6-a13e-104c439aebba", "f536c75a-a460-4ecb-a949-58305ba11968" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69d10e4c-0427-4448-a13e-104c439ae422", "69d10e4c-0427-4ee6-a13e-104c439ae888" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69d10e4c-0427-4ee6-a13e-104c439aebba", "f536c75a-a460-4ecb-a949-58305ba11968" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4448-a13e-104c439ae422");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4ee6-a13e-104c439aebba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4ee6-a13e-104c439ae888");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11968");
        }
    }
}
