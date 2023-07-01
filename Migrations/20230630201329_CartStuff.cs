using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class CartStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ba88d836-174d-4858-a693-3dcb7c1f3302", "14b320d7-a7f8-4614-bcf1-d697c2727983" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec396650-57f6-4219-bd2c-addd8277ab9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba88d836-174d-4858-a693-3dcb7c1f3302");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14b320d7-a7f8-4614-bcf1-d697c2727983");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "984dcc8a-0e9a-462b-9b71-f56ea3133349", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9f4d4804-8922-40d7-b2d6-c245b987599f", 0, null, null, "f34ebaa0-3dcf-4916-a45c-6507f7305305", null, "admin@videogameshop.com", true, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEFAQ8c+s80NBBbJFhnJPhF2Zu9kAVlE4ekssdlXM8OYSDTKSPiZIIsmcKk8x355v8g==", null, false, null, "0be7a38e-889f-49e2-846b-5d77bd56ab72", null, false, "admin" },
                    { "c0d7eb86-1b43-46d9-8047-11a5a4658708", 0, null, null, "28cd4ac3-96c8-4173-b287-b1e3622841d9", null, "user@videogameshop.com", true, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAELdr0PhsbhcOqlhrtesEah4/KMsfeFjgsc4e8TFzDH2sh6CF1sqOz8dnVTsYuJfV4Q==", null, false, null, "66165607-0f7c-4729-bb4b-47a9e5b1980b", null, false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "984dcc8a-0e9a-462b-9b71-f56ea3133349", "9f4d4804-8922-40d7-b2d6-c245b987599f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "984dcc8a-0e9a-462b-9b71-f56ea3133349", "9f4d4804-8922-40d7-b2d6-c245b987599f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0d7eb86-1b43-46d9-8047-11a5a4658708");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "984dcc8a-0e9a-462b-9b71-f56ea3133349");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f4d4804-8922-40d7-b2d6-c245b987599f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ba88d836-174d-4858-a693-3dcb7c1f3302", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "14b320d7-a7f8-4614-bcf1-d697c2727983", 0, null, null, "f25fb2b3-b7ae-4808-9733-4dc52e49d666", null, "admin@videogameshop.com", true, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEPGi7QZk9VSWuGtvSaJu3zS7IKF/GI/1XJ1E2iY55rNOg3WB7dnauFKbwk7P7/ULlA==", null, false, null, "cc7e7692-e824-43e7-a889-0238b079fd5d", null, false, "admin" },
                    { "ec396650-57f6-4219-bd2c-addd8277ab9d", 0, null, null, "0d10ce55-0452-434d-bb2f-7c4542627739", null, "user@videogameshop.com", true, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEOXfAlj8oGLNYn69HzbRxGY6zl1BqrWLHe+Mo7z3RjfxVZuO5i87aLw0dRm2jPrCtw==", null, false, null, "398e8a7a-6779-4ece-9514-a2951c4d49e2", null, false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ba88d836-174d-4858-a693-3dcb7c1f3302", "14b320d7-a7f8-4614-bcf1-d697c2727983" });
        }
    }
}
