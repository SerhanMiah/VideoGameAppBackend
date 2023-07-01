using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class shoppingcartremake : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "747bb61a-4a4a-4ca3-b115-fbfee22df68e", "57721c51-204a-4760-a610-0531f7581980" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "296c0018-6fd0-4097-a13b-45e920acb7df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "747bb61a-4a4a-4ca3-b115-fbfee22df68e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57721c51-204a-4760-a610-0531f7581980");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "caf7cb3e-37ff-4593-9d9c-9f2b9375174b", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c7c7859d-7838-488e-99b9-2dd8f829f0f4", 0, null, null, "0eeecd0b-a84d-4780-ae50-e83fada3c221", null, "admin@videogameshop.com", true, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAELpGZye1hmfVeTHjv0dy9Cavfch4kT/v+QFryHsbMxESN64+kDd9BBAvm2IYguGn7w==", null, false, null, "03962fda-2ef0-4391-bac9-c5d98f01a892", null, false, "admin" },
                    { "fdca4829-7c48-43cb-9209-b7da53e02a3a", 0, null, null, "9ed2db8f-6afb-4c18-befe-78718a9015b7", null, "user@videogameshop.com", true, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEA/MkWA7iS/AIB2LwxjutMpDuHml1plMJT429k6JjgEgsXZxf3AfJ8ucPMvCf7PqSA==", null, false, null, "837439cb-710a-4fad-be3d-3f8e503e6d64", null, false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "caf7cb3e-37ff-4593-9d9c-9f2b9375174b", "c7c7859d-7838-488e-99b9-2dd8f829f0f4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "caf7cb3e-37ff-4593-9d9c-9f2b9375174b", "c7c7859d-7838-488e-99b9-2dd8f829f0f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fdca4829-7c48-43cb-9209-b7da53e02a3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "caf7cb3e-37ff-4593-9d9c-9f2b9375174b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7c7859d-7838-488e-99b9-2dd8f829f0f4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "747bb61a-4a4a-4ca3-b115-fbfee22df68e", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "296c0018-6fd0-4097-a13b-45e920acb7df", 0, null, null, "f2fcd34d-dd65-4bab-92ee-3e0abdfdcd7c", null, "user@videogameshop.com", true, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEBChySNlIqRc5aYlT/195CTmJUvlc/Cjf34xFWERt8dS+q4PZx+KSISfHMuarYlpgA==", null, false, null, "ef63b318-a488-4595-8973-80de66e330fc", null, false, "user" },
                    { "57721c51-204a-4760-a610-0531f7581980", 0, null, null, "9f2a2b5a-73a3-4fb5-ab3d-764d9b342c6e", null, "admin@videogameshop.com", true, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAENmlJg0fcN1vBOrULOx8Q4w6sDCw1vyJrEOIWHS8pRLZUxwR/LGfEnpa5ukl/veVgg==", null, false, null, "5e0240c0-187d-42fe-ae3f-d1c6596ae75c", null, false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "747bb61a-4a4a-4ca3-b115-fbfee22df68e", "57721c51-204a-4760-a610-0531f7581980" });
        }
    }
}
