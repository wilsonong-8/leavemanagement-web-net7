using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedAnotherUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4ee6-a13e-104c439ae888",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de4f2121-82f0-45c3-9dd1-5927df70e3f5", "AQAAAAIAAYagAAAAELDvyd3EKmmpJF9HmQJuMQv/3XVZQzPfXGJISP7R7IxkA/JVZyYvrbVIv+LS+Wv/tw==", "3c5a3c61-db87-49b3-bc52-e6880aa42876" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ace68ee6-f23e-4944-8cf4-7da1a2cd5a7e", "AQAAAAIAAYagAAAAEA3c1FMrdK9Djw+eF5Y7uDCPQQTYI/MWX3eszNazhFcgFvkNlP1cBC6/cGpOhi9gEw==", "c7149327-24df-49ed-8d42-8594107bc6a7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f536c75a-a460-4ecb-a949-58305ba11977", 0, "3452d301-c816-49b4-8201-e90a82349427", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@gmail.com", true, "John", "Doe", false, null, "USER2@GMAIL.COM", "USER2@GMAIL.COM", "AQAAAAIAAYagAAAAEKWbyz1ytr3KEKAk/LTXhpWpNKDIOOwwijq5PTmPl6K3RoVJ1w6WiIPCb17n2t+XWA==", null, false, "dffedc81-8f93-4a49-ab24-32df240cfecd", null, false, "user2@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11977");

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
    }
}
