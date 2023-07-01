using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddUserToCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

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

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

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

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
