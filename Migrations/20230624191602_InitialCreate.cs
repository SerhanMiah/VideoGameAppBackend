using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ShippingAddress = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CardType = table.Column<int>(type: "int", nullable: true),
                    CardLastFourDigits = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CardExpirationDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    BankName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApplicationUserId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ShippingAddress = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TransactionId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "GameImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Url = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameImages", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Genre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Platform = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TrailerUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GameImageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_GameImages_GameImageId",
                        column: x => x.GameImageId,
                        principalTable: "GameImages",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fa0c994c-52c0-4014-a3da-4f50a7f27643", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShippingAddress", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e0f606c4-152f-4b49-b670-c1960e76a898", 0, "51c34350-caab-4173-a427-b9a0a6a27e2f", new DateTime(1998, 6, 24, 19, 16, 2, 781, DateTimeKind.Utc).AddTicks(3830), "user@videogameshop.com", true, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEPH+TRK0y0YmE7IQM/IDAwbtgswEFbPQ6WsvAC0lZq0ko3zZEtgFkAFP/FRYySh7Ww==", null, false, "c484b03d-d893-4429-af38-6dd347b31818", "User's address", false, "user" },
                    { "e776bc3c-6217-48c4-83df-e323c5341d78", 0, "510ed726-f11b-4dc6-b97d-d8de597457bb", new DateTime(1993, 6, 24, 19, 16, 2, 743, DateTimeKind.Utc).AddTicks(230), "admin@videogameshop.com", true, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEOITjZX0YQ5+3uZo62dKXeynnygHxM8N6rnl8bTi+dCDtPceAQl9dFFnJpyknYaJ7w==", null, false, "8544ab58-6e44-477b-82e4-58b389c7df08", "Admin's address", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "GameImageId", "Genre", "Platform", "Price", "ReleaseDate", "Title", "TrailerUrl" },
                values: new object[,]
                {
                    { 1, "Cyberpunk 2077 is an open-world, action-adventure story set in Night City.", null, "OpenWorld", "PC", 59.99m, new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cyberpunk 2077", "https://www.youtube.com/watch?v=ixl31324UxE" },
                    { 2, "Minecraft is a sandbox video game developed by Mojang.", null, "Sandbox", "PC", 26.95m, new DateTime(2011, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Minecraft", "https://www.youtube.com/watch?v=MmB9b5njVbA" },
                    { 3, "The Witcher 3: Wild Hunt is a story-driven, open world adventure set in a dark fantasy universe.", null, "RolePlaying", "PC", 39.99m, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt", "https://www.youtube.com/watch?v=HtVdAasjOgU" },
                    { 4, "From PlayStation Studios and Bluepoint Games comes a remake of the PlayStation classic.", null, "Action", "PlayStation5", 69.99m, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Demon's Souls", "https://www.youtube.com/watch?v=jGUtTPRuGak" },
                    { 5, "Join Ratchet and Clank as they take on an evil emperor from another reality.", null, "Adventure", "PlayStation5", 69.99m, new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ratchet & Clank: Rift Apart", "https://www.youtube.com/watch?v=ai3o0XtrnM8" },
                    { 6, "Returnal transforms roguelike gameplay into a third-person shooter where players fight to survive a hostile planet that changes with every death.", null, "Roguelike", "PlayStation5", 69.99m, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Returnal", "https://www.youtube.com/watch?v=Jv4BjWoB-NA" },
                    { 7, "Set five years after The Last of Us, players control an older Ellie who comes into conflict with a mysterious cult in a post-apocalyptic United States.", null, "Adventure", "PlayStation4", 59.99m, new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Last of Us Part II", "https://www.youtube.com/watch?v=btmN-bWwv0A" },
                    { 8, "God of War is an action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.", null, "Action", "PlayStation4", 19.99m, new DateTime(2018, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "God of War", "https://www.youtube.com/watch?v=K0u_kAWLJOA" },
                    { 9, "Uncharted 4: A Thief's End is an action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.", null, "Adventure", "PlayStation4", 19.99m, new DateTime(2016, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uncharted 4: A Thief's End", "https://www.youtube.com/watch?v=hh5HV4iic1Y" },
                    { 10, "Forza Horizon 4 is a racing video game set in an open world environment based in a fictional representation of areas of Great Britain.", null, "Racing", "XboxOne", 59.99m, new DateTime(2018, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forza Horizon 4", "https://www.youtube.com/watch?v=VmQNo8xtcAg" },
                    { 11, "Halo 5: Guardians is a first-person shooter video game developed by 343 Industries and published by Microsoft Studios.", null, "Shooter", "XboxOne", 19.99m, new DateTime(2015, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halo 5: Guardians", "https://www.youtube.com/watch?v=9rd8FWUCCZk" },
                    { 12, "Gears of War 4 is a third-person shooter video game developed by The Coalition and published by Microsoft Studios.", null, "ThirdPersonShooter", "XboxOne", 19.99m, new DateTime(2016, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gears of War 4", "https://www.youtube.com/watch?v=o3f8VgQ_dqk" },
                    { 13, "Assassin's Creed Valhalla is an action role-playing game set in the Viking Age.", null, "RolePlaying", "PC", 59.99m, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Valhalla", "https://www.youtube.com/watch?v=ssrBGE1g6g8" },
                    { 14, "Death Stranding is an action game set in an open world, with multiplayer functions.", null, "Action", "PC", 39.99m, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Death Stranding", "https://www.youtube.com/watch?v=piIgkJWDuQg" },
                    { 15, "Grand Theft Auto V is an action-adventure game played from either a first-person or third-person perspective.", null, "Adventure", "PC", 29.99m, new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grand Theft Auto V", "https://www.youtube.com/watch?v=QkkoHAzjnUs" },
                    { 16, "Marvel's Spider-Man: Miles Morales is an action-adventure game based on the Marvel Comics superhero Miles Morales.", null, "Adventure", "PlayStation5", 49.99m, new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvel's Spider-Man: Miles Morales", "https://www.youtube.com/watch?v=NTunTURbyUU" },
                    { 17, "Resident Evil Village is a survival horror game and the eighth main installment in the Resident Evil series.", null, "Horror", "PlayStation5", 59.99m, new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resident Evil Village", "https://www.youtube.com/watch?v=oxZ4mqV0wGQ" },
                    { 18, "Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles is an anime-based action game.", null, "Action", "PlayStation5", 59.99m, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles", "https://www.youtube.com/watch?v=iXv_Rw9A4RU" },
                    { 19, "FIFA 22 is a football simulation video game and the latest installment in the FIFA series.", null, "Sports", "XboxSeriesX", 59.99m, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FIFA 22", "https://www.youtube.com/watch?v=WRznO7KYSP4" },
                    { 20, "Hades is a roguelike action role-playing game where players control the prince of the underworld.", null, "RolePlaying", "XboxSeriesX", 29.99m, new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hades", "https://www.youtube.com/watch?v=NOGUK4EyZgk" },
                    { 21, "Psychonauts 2 is a platforming game and the sequel to the original Psychonauts.", null, "Action", "XboxSeriesX", 59.99m, new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Psychonauts 2", "https://www.youtube.com/watch?v=ssrBGE1g6g8" },
                    { 22, "The Elder Scrolls V: Skyrim is an open-world action role-playing game developed by Bethesda Game Studios.", null, "RolePlaying", "PC", 39.99m, new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim", "https://www.youtube.com/watch?v=PjqsYzBrP-M" },
                    { 23, "World of Warcraft is a massively multiplayer online role-playing game set in the Warcraft fantasy universe.", null, "RolePlaying", "PC", 14.99m, new DateTime(2004, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "World of Warcraft", "https://www.youtube.com/watch?v=jSJr3dXZfcg" },
                    { 24, "Fallout 4 is an open-world action role-playing game developed by Bethesda Game Studios.", null, "RolePlaying", "PC", 29.99m, new DateTime(2015, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fallout 4", "https://www.youtube.com/watch?v=D5esyZPt5Jo" },
                    { 25, "Horizon Forbidden West is an action role-playing game and the sequel to Horizon Zero Dawn.", null, "Action", "PlayStation5", 69.99m, new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Horizon Forbidden West", "https://www.youtube.com/watch?v=Lq594XmpPBg" },
                    { 26, "Ghost of Tsushima is an action-adventure game set in feudal Japan.", null, "Action", "PlayStation5", 59.99m, new DateTime(2020, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghost of Tsushima", "https://www.youtube.com/watch?v=hRxZQqo5k7I" },
                    { 27, "Final Fantasy VII Remake is a role-playing game and a remake of the 1997 game Final Fantasy VII.", null, "RolePlaying", "PlayStation5", 69.99m, new DateTime(2020, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Fantasy VII Remake", "https://www.youtube.com/watch?v=0wAHEVUwZk4" },
                    { 28, "Gears 5 is a third-person shooter game developed by The Coalition.", null, "ThirdPersonShooter", "XboxSeriesX", 39.99m, new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gears 5", "https://www.youtube.com/watch?v=o3f8VgQ_dqk" },
                    { 29, "Ori and the Will of the Wisps is a platform-adventure Metroidvania game.", null, "Adventure", "XboxSeriesX", 29.99m, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ori and the Will of the Wisps", "https://www.youtube.com/watch?v=2zM8LclFhFw" },
                    { 30, "Sea of Thieves is an action-adventure game set in an open world multiplayer environment.", null, "Adventure", "XboxSeriesX", 49.99m, new DateTime(2018, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sea of Thieves", "https://www.youtube.com/watch?v=r5JlZLCVAg0" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fa0c994c-52c0-4014-a3da-4f50a7f27643", "e776bc3c-6217-48c4-83df-e323c5341d78" });

            migrationBuilder.InsertData(
                table: "GameImages",
                columns: new[] { "Id", "GameId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547909/VideoGameShop/Cyberpunk%202077/cyberpunk_2077_unreal_engine_5_wjauye.png" },
                    { 2, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547906/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-phantom-liberty_fuqyge.webp" },
                    { 3, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk_2077_bztuyy.webp" },
                    { 4, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" },
                    { 5, 1, "https://res.cloudinary.com/danedskby/image/upload/v1687547902/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-game-of-the-year-edition-scaled-e1670012903149_jpzcd6.webp" },
                    { 6, 2, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_Minecraft.jpg" },
                    { 7, 2, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_Minecraft.jpg" },
                    { 8, 2, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_Minecraft.jpg" },
                    { 9, 2, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_Minecraft.jpg" },
                    { 10, 2, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_Minecraft.jpg" },
                    { 11, 3, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_TheWitcher3WildHunt_enGB_image1600w.jpg" },
                    { 12, 3, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_TheWitcher3WildHunt_enGB_image1600w.jpg" },
                    { 13, 3, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_TheWitcher3WildHunt_enGB_image1600w.jpg" },
                    { 14, 3, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_TheWitcher3WildHunt_enGB_image1600w.jpg" },
                    { 15, 3, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_TheWitcher3WildHunt_enGB_image1600w.jpg" },
                    { 16, 4, "https://res.cloudinary.com/danedskby/image/upload/v1687547912/VideoGameShop/DemonSoul/gAP2DGRWpFSehL2GDrcsPL_ienhqh.jpg" },
                    { 17, 4, "https://res.cloudinary.com/danedskby/image/upload/v1687547907/VideoGameShop/DemonSoul/p3BNVCDOeLpb3bWAptk2Hi2t_v4hfbq.webp" },
                    { 18, 4, "https://res.cloudinary.com/danedskby/image/upload/v1687547904/VideoGameShop/DemonSoul/demonssouls-review-blogroll-1605559895476_160w_z5fsmg.jpg" },
                    { 19, 4, "https://res.cloudinary.com/danedskby/image/upload/v1687547904/VideoGameShop/DemonSoul/demonssouls-review-blogroll-1605559895476_160w_z5fsmg.jpg" },
                    { 20, 4, "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/DemonSoul/demons-souls-penetrator.large_vz9tfp.jpg" },
                    { 21, 5, "https://res.cloudinary.com/danedskby/image/upload/v1687547912/VideoGameShop/Ratchet-Clank-Rift%20Apart/RC_RiftApart_Heroes_PS5-scaled_u56nzf.jpg" },
                    { 22, 5, "https://res.cloudinary.com/danedskby/image/upload/v1687547909/VideoGameShop/Ratchet-Clank-Rift%20Apart/RC_RiftApart_Who_PS5-scaled_zabzju.jpg" },
                    { 23, 5, "https://res.cloudinary.com/danedskby/image/upload/v1687547905/VideoGameShop/Ratchet-Clank-Rift%20Apart/DwVjpbKOsFOyPdNzmSTSWuxG_obxxbq.webp" },
                    { 24, 5, "https://res.cloudinary.com/danedskby/image/upload/v1687547905/VideoGameShop/Ratchet-Clank-Rift%20Apart/Ratchet-and-Clank-Rift-Apart-PS4-fc20022_rd0biw.jpg" },
                    { 25, 5, "https://res.cloudinary.com/danedskby/image/upload/v1687547904/VideoGameShop/Ratchet-Clank-Rift%20Apart/716cb9b0c815dd9a4ff2b198a5ba13a4d58dfa01-scaled_zhguda.webp" },
                    { 26, 6, "https://res.cloudinary.com/danedskby/image/upload/v1687547910/VideoGameShop/Returnal/81jyDN6P9vL_p3u8ms.jpg" },
                    { 27, 6, "https://res.cloudinary.com/danedskby/image/upload/v1687547909/VideoGameShop/Returnal/jACA12Z58ka5V6vvxlcdoQfJ_sykmv1.avif" },
                    { 28, 6, "https://res.cloudinary.com/danedskby/image/upload/v1687547909/VideoGameShop/Returnal/4ItSbqJE88H019Ua3WBQKLF8_mfw76m.avif" },
                    { 29, 6, "https://res.cloudinary.com/danedskby/image/upload/v1687547906/VideoGameShop/Returnal/returnalsurvive_wiqjhb.jpg" },
                    { 30, 6, "https://res.cloudinary.com/danedskby/image/upload/v1687547905/VideoGameShop/Returnal/h3returnalh3brbdelayed-from-march-19-to-april-30-2021bbrbrre_8g1s.1280_n4y5sg.webp" },
                    { 31, 7, "https://assets1.ignimgs.com/2020/05/19/lastofuspart2-blogroll-1589913932452_160w.jpg?width=1280" },
                    { 32, 7, "https://assets1.ignimgs.com/2020/05/19/lastofuspart2-blogroll-1589913932452_160w.jpg?width=1280" },
                    { 33, 7, "https://assets1.ignimgs.com/2020/05/19/lastofuspart2-blogroll-1589913932452_160w.jpg?width=1280" },
                    { 34, 7, "https://assets1.ignimgs.com/2020/05/19/lastofuspart2-blogroll-1589913932452_160w.jpg?width=1280" },
                    { 35, 7, "https://assets1.ignimgs.com/2020/05/19/lastofuspart2-blogroll-1589913932452_160w.jpg?width=1280" },
                    { 36, 8, "https://m.media-amazon.com/images/I/A1b0TAVpyEL._AC_UF894,1000_QL80_.jpg" },
                    { 37, 8, "https://m.media-amazon.com/images/I/A1b0TAVpyEL._AC_UF894,1000_QL80_.jpg" },
                    { 38, 8, "https://m.media-amazon.com/images/I/A1b0TAVpyEL._AC_UF894,1000_QL80_.jpg" },
                    { 39, 8, "https://m.media-amazon.com/images/I/A1b0TAVpyEL._AC_UF894,1000_QL80_.jpg" },
                    { 40, 8, "https://m.media-amazon.com/images/I/A1b0TAVpyEL._AC_UF894,1000_QL80_.jpg" },
                    { 41, 9, "https://image.api.playstation.com/vulcan/img/rnd/202010/2620/eIO6Ka26JChNo8KaFi7wON4L.jpg" },
                    { 42, 9, "https://image.api.playstation.com/vulcan/img/rnd/202010/2620/eIO6Ka26JChNo8KaFi7wON4L.jpg" },
                    { 43, 9, "https://image.api.playstation.com/vulcan/img/rnd/202010/2620/eIO6Ka26JChNo8KaFi7wON4L.jpg" },
                    { 44, 9, "https://image.api.playstation.com/vulcan/img/rnd/202010/2620/eIO6Ka26JChNo8KaFi7wON4L.jpg" },
                    { 45, 9, "https://image.api.playstation.com/vulcan/img/rnd/202010/2620/eIO6Ka26JChNo8KaFi7wON4L.jpg" },
                    { 46, 10, "https://assets.xboxservices.com/assets/1d/8f/1d8f5d61-2a8c-4377-a512-88b060deeaf4.jpg?n=FH4_GLP-Page-Hero-1084_1920x1080_02.jpg" },
                    { 47, 10, "https://assets.xboxservices.com/assets/1d/8f/1d8f5d61-2a8c-4377-a512-88b060deeaf4.jpg?n=FH4_GLP-Page-Hero-1084_1920x1080_02.jpg" },
                    { 48, 10, "https://assets.xboxservices.com/assets/1d/8f/1d8f5d61-2a8c-4377-a512-88b060deeaf4.jpg?n=FH4_GLP-Page-Hero-1084_1920x1080_02.jpg" },
                    { 49, 10, "https://assets.xboxservices.com/assets/1d/8f/1d8f5d61-2a8c-4377-a512-88b060deeaf4.jpg?n=FH4_GLP-Page-Hero-1084_1920x1080_02.jpg" },
                    { 50, 10, "https://assets.xboxservices.com/assets/1d/8f/1d8f5d61-2a8c-4377-a512-88b060deeaf4.jpg?n=FH4_GLP-Page-Hero-1084_1920x1080_02.jpg" },
                    { 51, 11, "https://gaming-cdn.com/images/products/9598/orig/halo-5-guardians-pc-game-steam-cover.jpg?v=1668692780" },
                    { 52, 11, "https://gaming-cdn.com/images/products/9598/orig/halo-5-guardians-pc-game-steam-cover.jpg?v=1668692780" },
                    { 53, 11, "https://gaming-cdn.com/images/products/9598/orig/halo-5-guardians-pc-game-steam-cover.jpg?v=1668692780" },
                    { 54, 11, "https://gaming-cdn.com/images/products/9598/orig/halo-5-guardians-pc-game-steam-cover.jpg?v=1668692780" },
                    { 55, 11, "https://gaming-cdn.com/images/products/9598/orig/halo-5-guardians-pc-game-steam-cover.jpg?v=1668692780" },
                    { 56, 12, "https://assets.xboxservices.com/assets/2b/42/2b42b33c-cc7f-4162-9eaa-48e5cc88e6fe.jpg?n=GoW4-MWF_Hero-0_1083x609.jpg" },
                    { 57, 12, "https://assets.xboxservices.com/assets/2b/42/2b42b33c-cc7f-4162-9eaa-48e5cc88e6fe.jpg?n=GoW4-MWF_Hero-0_1083x609.jpg" },
                    { 58, 12, "https://assets.xboxservices.com/assets/2b/42/2b42b33c-cc7f-4162-9eaa-48e5cc88e6fe.jpg?n=GoW4-MWF_Hero-0_1083x609.jpg" },
                    { 59, 12, "https://assets.xboxservices.com/assets/2b/42/2b42b33c-cc7f-4162-9eaa-48e5cc88e6fe.jpg?n=GoW4-MWF_Hero-0_1083x609.jpg" },
                    { 60, 12, "https://assets.xboxservices.com/assets/2b/42/2b42b33c-cc7f-4162-9eaa-48e5cc88e6fe.jpg?n=GoW4-MWF_Hero-0_1083x609.jpg" },
                    { 61, 13, "https://image.api.playstation.com/vulcan/ap/rnd/202006/1520/EDtkdijFRwbmGKk1G9lrDoEF.png" },
                    { 62, 13, "https://image.api.playstation.com/vulcan/ap/rnd/202006/1520/EDtkdijFRwbmGKk1G9lrDoEF.png" },
                    { 63, 13, "https://image.api.playstation.com/vulcan/ap/rnd/202006/1520/EDtkdijFRwbmGKk1G9lrDoEF.png" },
                    { 64, 13, "https://image.api.playstation.com/vulcan/ap/rnd/202006/1520/EDtkdijFRwbmGKk1G9lrDoEF.png" },
                    { 65, 13, "https://image.api.playstation.com/vulcan/ap/rnd/202006/1520/EDtkdijFRwbmGKk1G9lrDoEF.png" },
                    { 66, 14, "https://m.media-amazon.com/images/M/MV5BMjIxZTljZGItZTIwYS00ZjIzLWJlZTMtZWIyODg0NjA0NTNmXkEyXkFqcGdeQXVyMTI0MzA4NTgw._V1_.jpg" },
                    { 67, 14, "https://m.media-amazon.com/images/M/MV5BMjIxZTljZGItZTIwYS00ZjIzLWJlZTMtZWIyODg0NjA0NTNmXkEyXkFqcGdeQXVyMTI0MzA4NTgw._V1_.jpg" },
                    { 68, 14, "https://m.media-amazon.com/images/M/MV5BMjIxZTljZGItZTIwYS00ZjIzLWJlZTMtZWIyODg0NjA0NTNmXkEyXkFqcGdeQXVyMTI0MzA4NTgw._V1_.jpg" },
                    { 69, 14, "https://m.media-amazon.com/images/M/MV5BMjIxZTljZGItZTIwYS00ZjIzLWJlZTMtZWIyODg0NjA0NTNmXkEyXkFqcGdeQXVyMTI0MzA4NTgw._V1_.jpg" },
                    { 70, 14, "https://m.media-amazon.com/images/M/MV5BMjIxZTljZGItZTIwYS00ZjIzLWJlZTMtZWIyODg0NjA0NTNmXkEyXkFqcGdeQXVyMTI0MzA4NTgw._V1_.jpg" },
                    { 71, 15, "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png" },
                    { 72, 15, "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png" },
                    { 73, 15, "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png" },
                    { 74, 15, "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png" },
                    { 75, 15, "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png" },
                    { 76, 16, "https://gaming-cdn.com/images/products/12953/orig/marvel-s-spider-man-miles-morales-pc-game-steam-cover.jpg?v=1683639469" },
                    { 77, 16, "https://gaming-cdn.com/images/products/12953/orig/marvel-s-spider-man-miles-morales-pc-game-steam-cover.jpg?v=1683639469" },
                    { 78, 16, "https://gaming-cdn.com/images/products/12953/orig/marvel-s-spider-man-miles-morales-pc-game-steam-cover.jpg?v=1683639469" },
                    { 79, 16, "https://gaming-cdn.com/images/products/12953/orig/marvel-s-spider-man-miles-morales-pc-game-steam-cover.jpg?v=1683639469" },
                    { 80, 16, "https://gaming-cdn.com/images/products/12953/orig/marvel-s-spider-man-miles-morales-pc-game-steam-cover.jpg?v=1683639469" },
                    { 81, 17, "https://assetsio.reedpopcdn.com/Resident-Evil-Village-Gold-Edition.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" },
                    { 82, 17, "https://assetsio.reedpopcdn.com/Resident-Evil-Village-Gold-Edition.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" },
                    { 83, 17, "https://assetsio.reedpopcdn.com/Resident-Evil-Village-Gold-Edition.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" },
                    { 84, 17, "https://assetsio.reedpopcdn.com/Resident-Evil-Village-Gold-Edition.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" },
                    { 85, 17, "https://assetsio.reedpopcdn.com/Resident-Evil-Village-Gold-Edition.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" },
                    { 86, 18, "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi5HQma8l42yiEEs8TntdfI_YxYjwcHpFvARIVtxqqukFwKsIlnk_f7uqt3Fv_UniTPENV0YSB6lSiIlAubWNOBjbpVXXcjx-faWPurBEw3crAGkIQdTj8yzKCACHq6sCeRPkYtXESpLjUcDu5_VY3W8z6LfCJSpt8IVfRipQ6QMH92cj4ea4mBLTXP/s1280/Demon-Slayer-Kimetsu-no-Yaiba-The-Hinokami-Chronicles-Switch-physical-release.jpg" },
                    { 87, 18, "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi5HQma8l42yiEEs8TntdfI_YxYjwcHpFvARIVtxqqukFwKsIlnk_f7uqt3Fv_UniTPENV0YSB6lSiIlAubWNOBjbpVXXcjx-faWPurBEw3crAGkIQdTj8yzKCACHq6sCeRPkYtXESpLjUcDu5_VY3W8z6LfCJSpt8IVfRipQ6QMH92cj4ea4mBLTXP/s1280/Demon-Slayer-Kimetsu-no-Yaiba-The-Hinokami-Chronicles-Switch-physical-release.jpg" },
                    { 88, 18, "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi5HQma8l42yiEEs8TntdfI_YxYjwcHpFvARIVtxqqukFwKsIlnk_f7uqt3Fv_UniTPENV0YSB6lSiIlAubWNOBjbpVXXcjx-faWPurBEw3crAGkIQdTj8yzKCACHq6sCeRPkYtXESpLjUcDu5_VY3W8z6LfCJSpt8IVfRipQ6QMH92cj4ea4mBLTXP/s1280/Demon-Slayer-Kimetsu-no-Yaiba-The-Hinokami-Chronicles-Switch-physical-release.jpg" },
                    { 89, 18, "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi5HQma8l42yiEEs8TntdfI_YxYjwcHpFvARIVtxqqukFwKsIlnk_f7uqt3Fv_UniTPENV0YSB6lSiIlAubWNOBjbpVXXcjx-faWPurBEw3crAGkIQdTj8yzKCACHq6sCeRPkYtXESpLjUcDu5_VY3W8z6LfCJSpt8IVfRipQ6QMH92cj4ea4mBLTXP/s1280/Demon-Slayer-Kimetsu-no-Yaiba-The-Hinokami-Chronicles-Switch-physical-release.jpg" },
                    { 90, 18, "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi5HQma8l42yiEEs8TntdfI_YxYjwcHpFvARIVtxqqukFwKsIlnk_f7uqt3Fv_UniTPENV0YSB6lSiIlAubWNOBjbpVXXcjx-faWPurBEw3crAGkIQdTj8yzKCACHq6sCeRPkYtXESpLjUcDu5_VY3W8z6LfCJSpt8IVfRipQ6QMH92cj4ea4mBLTXP/s1280/Demon-Slayer-Kimetsu-no-Yaiba-The-Hinokami-Chronicles-Switch-physical-release.jpg" },
                    { 91, 19, "https://library.sportingnews.com/styles/facebook_1200x630/s3/2021-10/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg?itok=B0Ysb2Rj" },
                    { 92, 19, "https://library.sportingnews.com/styles/facebook_1200x630/s3/2021-10/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg?itok=B0Ysb2Rj" },
                    { 93, 19, "https://library.sportingnews.com/styles/facebook_1200x630/s3/2021-10/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg?itok=B0Ysb2Rj" },
                    { 94, 19, "https://library.sportingnews.com/styles/facebook_1200x630/s3/2021-10/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg?itok=B0Ysb2Rj" },
                    { 95, 19, "https://library.sportingnews.com/styles/facebook_1200x630/s3/2021-10/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg?itok=B0Ysb2Rj" },
                    { 96, 20, "https://cdn.vox-cdn.com/thumbor/P5qcFEfltn2W-VVjvjHdGtBjGN4=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/22138421/jbareham_201201_ecl1050_goty_2020_top_10__1_HADES.jpg" },
                    { 97, 20, "https://d1w82usnq70pt2.cloudfront.net/wp-content/uploads/2020/01/hadesgoonheader.png" },
                    { 98, 20, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_Hades_image1600w.png" },
                    { 99, 20, "https://preview.redd.it/8uwps0hac4s81.jpg?auto=webp&s=eb79577f9e3cbb2e38f0b386c5ad81882397f151" },
                    { 100, 20, "https://assets.rockpapershotgun.com/images/2019/01/hades-e.jpg" },
                    { 101, 21, "https://upload.wikimedia.org/wikipedia/en/2/23/Psychonauts_2_cover.png" },
                    { 102, 21, "https://i.guim.co.uk/img/media/4aa09e45bb80928fc52442e3072edeba6e1001b5/144_0_3600_2160/master/3600.jpg?width=1200&height=1200&quality=85&auto=format&fit=crop&s=2fc06be6382ce01bea378e17a9642dfa" },
                    { 103, 21, "https://assets.xboxservices.com/assets/94/e6/94e658f8-20d5-4419-988c-7603eb297a42.jpg?n=Psychonauts-2_GLP-Page-Hero-1084_Cinemagraph-Poster-Image_1920x1080.jpg" },
                    { 104, 21, "https://static1.thegamerimages.com/wordpress/wp-content/uploads/2022/12/raz-milla-and-lucrecia-from-psychonauts-2.jpg" },
                    { 105, 21, "https://www.gameinformer.com/sites/default/files/styles/thumbnail/public/2021/06/13/3a37e59e/psychonauts2_01.jpg" },
                    { 106, 22, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_TheElderScrollsVSkyrim_image1600w.jpg" },
                    { 107, 22, "https://image.api.playstation.com/vulcan/ap/rnd/202110/2019/aDSOgerXg4V6sf5A7VzHiTun.jpg" },
                    { 108, 22, "https://i.ebayimg.com/images/g/Ag0AAOSwhBxjP~Z5/s-l960.jpg" },
                    { 109, 22, "https://i.gadgets360cdn.com/large/skyrim_remaster_1477475720488.jpeg" },
                    { 110, 22, "https://media.wired.com/photos/5a8f7d06b4bf6c3e4d4058c0/master/w_1600%2Cc_limit/skyrim-0004.jpg" },
                    { 111, 23, "https://static.wikia.nocookie.net/wowpedia/images/a/aa/WoW_2.0_logo_old.png/revision/latest?cb=20180705205814" },
                    { 112, 23, "https://media.wired.com/photos/5eb064fb568b219656eb598a/master/w_2560%2Cc_limit/Culture_Ardenweald_1920x1080.jpg" },
                    { 113, 23, "https://blz-contentstack-images.akamaized.net/v3/assets/bltf408a0557f4e4998/bltd6a3e4b53209d445/63ec05bc9fcac365e25253a0/WoW_Free_Trial_BG.png?width=&format=webply&dpr=2&disable=upscale&quality=80" },
                    { 114, 23, "https://images.cgames.de/images/gamestar/4/wow-dragonflight-teaser_6177226.jpg" },
                    { 115, 23, "https://assetsio.reedpopcdn.com/World-Of-Warcraft-Wrath-Of-The-Lich-King.jpg?width=1200&height=1200&fit=crop&quality=100&format=png&enable=upscale&auto=webp" },
                    { 116, 24, "https://image.api.playstation.com/vulcan/ap/rnd/202009/2500/4GZyUQ1bHTjICP6GCRG7f65n.png" },
                    { 117, 24, "https://cdn.vox-cdn.com/thumbor/Fy1WKM1aEXO4VT6_WvIGQNtMC68=/155x0:1842x1125/1280x854/cdn.vox-cdn.com/uploads/chorus_image/image/47619447/Fallout4_Trailer_End_1433355589.0.0.jpg" },
                    { 118, 24, "https://www.trustedreviews.com/wp-content/uploads/sites/54/2015/11/Fallout-4-1-2.jpg" },
                    { 119, 24, "https://images.ladbible.com/resize?type=jpeg&quality=70&width=720&fit=contain&gravity=null&url=https://eu-images.contentstack.com/v3/assets/bltbc1876152fcd9f07/blt4803eee048f0ddc1/647e01820f2fc184b19c8db1/fallout_4_fan_remake.png" },
                    { 120, 24, "https://assetsio.reedpopcdn.com/1.bmp_jQm0xJ3.jpg?width=1200&height=1200&fit=bounds&quality=70&format=jpg&auto=webp" },
                    { 121, 25, "https://res.cloudinary.com/danedskby/image/upload/v1687633010/VideoGameShop/Horizon%20Forbidden%20West/horizon-forbidden-west-alpha-leak-scaled-e1672388177340_kmjzqr.jpg" },
                    { 122, 25, "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/Games-Horizon-Forbidden-West-Review-top_q8ujyy.webp" },
                    { 123, 25, "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/HO8vkO9pfXhwbHi5WHECQJdN_orvh7x.webp" },
                    { 124, 25, "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/UwYhuHgLaRtpq9eXUBuwaM_mb1ns8.jpg" },
                    { 125, 25, "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/resize_fomk2i.jpg" },
                    { 126, 26, "https://res.cloudinary.com/danedskby/image/upload/v1687632890/VideoGameShop/Call%20of%20Duty-%20Warzone/WZM-LIMITEDRELEASE-1128-TOUT_h3qti8.jpg" },
                    { 127, 26, "https://res.cloudinary.com/danedskby/image/upload/v1687632890/VideoGameShop/Call%20of%20Duty-%20Warzone/Warzone_glsmxq.png" },
                    { 128, 26, "https://res.cloudinary.com/danedskby/image/upload/v1687632889/VideoGameShop/Call%20of%20Duty-%20Warzone/warzone-s2-meta-a86a_l6ctn7.webp" },
                    { 129, 26, "https://res.cloudinary.com/danedskby/image/upload/v1687632889/VideoGameShop/Call%20of%20Duty-%20Warzone/ss_3c2893dd47a7e62b98e04e4a62f28e2f28d17ba5.1920x1080_m2op1k.jpg" },
                    { 130, 26, "https://res.cloudinary.com/danedskby/image/upload/v1687632888/VideoGameShop/Call%20of%20Duty-%20Warzone/MWII-NEXT-COD-WZM-TOUT_bws5ta.jpg" },
                    { 131, 27, "https://res.cloudinary.com/danedskby/image/upload/v1687632765/VideoGameShop/Fortnite/2x1_NSwitchDS_Fortnite_w2tovi.jpg" },
                    { 132, 27, "https://res.cloudinary.com/danedskby/image/upload/v1687632764/VideoGameShop/Fortnite/fortnite-home-page-zero-build-promo-slide-desktop-1920x1080-4272f6b5e69e_y8rwth.jpg" },
                    { 133, 27, "https://res.cloudinary.com/danedskby/image/upload/v1687632764/VideoGameShop/Fortnite/1200_tgvg5u.webp" },
                    { 134, 27, "https://res.cloudinary.com/danedskby/image/upload/v1687632764/VideoGameShop/Fortnite/1080_fjmkvp.webp" },
                    { 135, 27, "https://res.cloudinary.com/danedskby/image/upload/v1687632764/VideoGameShop/Fortnite/1207_rdyajp.webp" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_GameId",
                table: "CartItems",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GameImages_GameId",
                table: "GameImages",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GameImageId",
                table: "Games",
                column: "GameImageId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_GameId",
                table: "OrderItems",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ApplicationUserId",
                table: "Orders",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Games_GameId",
                table: "CartItems",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameImages_Games_GameId",
                table: "GameImages",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameImages_Games_GameId",
                table: "GameImages");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "GameImages");
        }
    }
}
