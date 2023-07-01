using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddWishListEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3abc1a08-0890-42b3-a7d5-c5eea778039a", "a900baf4-dd88-4e97-b030-d65e9ab8c177" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09846c3d-59aa-49f6-8d34-0dbe844834e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3abc1a08-0890-42b3-a7d5-c5eea778039a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a900baf4-dd88-4e97-b030-d65e9ab8c177");

            migrationBuilder.CreateTable(
                name: "WishLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishLists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WishlistItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WishlistId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishlistItems_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishlistItems_WishLists_WishlistId",
                        column: x => x.WishlistId,
                        principalTable: "WishLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a31ca15-c835-4e38-8f78-860262b93f8c", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "56254bc6-43b0-4fa1-9ad6-8a74da5cab00", 0, "", null, "66f0381c-65d6-43d0-a655-d20ef0bfc08f", null, "user@videogameshop.com", true, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEALaGobBI0p2RslSDQj+mn4NtiJFrzRygaLWYNh7N1h5EuThTgP6t4lwM1E7YgeJVQ==", null, false, null, "e6d069a1-a694-4ba1-b7d5-7e151e701fbb", null, false, "user" },
                    { "d8ff74d4-144e-4eb2-a633-10bd3cb8428e", 0, "", null, "82ed1aa3-db85-4ac5-97e8-a941f457adc1", null, "admin@videogameshop.com", true, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEB7pRWYjal8Yunvc869/7AUWBaJsD5F3k1gxJ9+bPNKANaPG/I89lJcZgTIrPb6TTQ==", null, false, null, "ee9363e7-cf9b-442a-84b1-3730249aefae", null, false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9a31ca15-c835-4e38-8f78-860262b93f8c", "d8ff74d4-144e-4eb2-a633-10bd3cb8428e" });

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_GameId",
                table: "WishlistItems",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_WishlistId",
                table: "WishlistItems",
                column: "WishlistId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLists_UserId",
                table: "WishLists",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WishlistItems");

            migrationBuilder.DropTable(
                name: "WishLists");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a31ca15-c835-4e38-8f78-860262b93f8c", "d8ff74d4-144e-4eb2-a633-10bd3cb8428e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56254bc6-43b0-4fa1-9ad6-8a74da5cab00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a31ca15-c835-4e38-8f78-860262b93f8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8ff74d4-144e-4eb2-a633-10bd3cb8428e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3abc1a08-0890-42b3-a7d5-c5eea778039a", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostalCode", "SecurityStamp", "State", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09846c3d-59aa-49f6-8d34-0dbe844834e5", 0, "", null, "e20f20ff-d24d-4752-ba7c-643bbf859ef5", null, "user@videogameshop.com", true, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEKdHDNEdcEzexK2qRt67Jbw5yPkD4MUW0SpVKzPThZHz0o/knjZnOaxxx+/fB38v1Q==", null, false, null, "0daf0282-0bcf-48fb-933c-8e9faf8eb8df", null, false, "user" },
                    { "a900baf4-dd88-4e97-b030-d65e9ab8c177", 0, "", null, "de8070a0-ab2d-44cc-8842-33a4807e6a71", null, "admin@videogameshop.com", true, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEF+JoVOmdnI7PC+mpGUDag24BI8Kh/w+8siD6fnlE8p1PEHnFbL7pRN67OicIqXPeA==", null, false, null, "ac572878-ce0e-4a32-a933-6426451fc3e3", null, false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3abc1a08-0890-42b3-a7d5-c5eea778039a", "a900baf4-dd88-4e97-b030-d65e9ab8c177" });
        }
    }
}
