using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddReviewUserRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "AspNetUsers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_GameId",
                table: "Reviews",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

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

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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
    }
}
