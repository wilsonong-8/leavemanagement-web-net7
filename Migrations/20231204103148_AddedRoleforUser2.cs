using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoleforUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "69d10e4c-0427-4ee6-a13e-104c439aebba", "f536c75a-a460-4ecb-a949-58305ba11977" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69d10e4c-0427-4ee6-a13e-104c439ae888",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e16b57ff-317c-43e6-a6fa-c80a7dd51230", "AQAAAAIAAYagAAAAEJRzWZLse8ubwcgP6Ekn2WipQjo5TE1XciUxRaqPt5nbWfY0N40HDdZc1b4NdA2HsA==", "b2f6774c-d8a3-49d9-aa0d-e9f925d0c856" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11968",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "053ea43c-2113-4c8c-af1c-df8e8c11eea8", "AQAAAAIAAYagAAAAENkEBm+bPm79ee55ExZZysgoeB2PfsciE7U3g8AzLzsRVkaFMsdW5Hq6Zn3qa5icdw==", "16ed8710-7e4f-41e0-8d92-d44fc6669b87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11977",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4022f0c0-05f5-48ac-a451-c7a4e3c46379", "AQAAAAIAAYagAAAAEOHPhr+h8F0Nvhzsw8gY58WrH9+MkSqLHaZ/C3sm2HFGK2I7gZp9YM/8vx9eIY+RTw==", "9c1bab8f-2234-424a-ac76-c633806a67e9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "69d10e4c-0427-4ee6-a13e-104c439aebba", "f536c75a-a460-4ecb-a949-58305ba11977" });

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f536c75a-a460-4ecb-a949-58305ba11977",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3452d301-c816-49b4-8201-e90a82349427", "AQAAAAIAAYagAAAAEKWbyz1ytr3KEKAk/LTXhpWpNKDIOOwwijq5PTmPl6K3RoVJ1w6WiIPCb17n2t+XWA==", "dffedc81-8f93-4a49-ab24-32df240cfecd" });
        }
    }
}
