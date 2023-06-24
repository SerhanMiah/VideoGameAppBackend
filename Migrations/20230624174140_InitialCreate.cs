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
                    Url = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
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
                values: new object[] { "2e65885a-dbd2-4968-84a9-ef8da610b698", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShippingAddress", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0cd10475-0f3d-4995-9bad-c5e6591d804c", 0, "74fe0e30-1105-4440-9633-8e8e5b4f8523", new DateTime(1993, 6, 24, 17, 41, 40, 495, DateTimeKind.Utc).AddTicks(2250), "admin@videogameshop.com", true, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEDQ2u2/OEssNirnnRwTxiEnmTABIflQUPTeulRy0c0XVTwm6+qgNFBQlop2N9IeWJA==", null, false, "990cc78e-7f60-46e8-baec-eb42404cd730", "Admin's address", false, "admin" },
                    { "6ef492e7-6daf-47ae-b5d7-07a357206082", 0, "937b0f85-7ab1-4475-82c5-88cd9cc9568c", new DateTime(1998, 6, 24, 17, 41, 40, 533, DateTimeKind.Utc).AddTicks(8320), "user@videogameshop.com", true, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEPzpKivbi7YV+KJYW8H9V3uJAZVJyRuxaVoK0XqXOB/sbHv4evEt01/YaA/u4I6ipw==", null, false, "6979cc4b-e883-4025-a9f4-5e060c930d74", "User's address", false, "user" }
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
                values: new object[] { "2e65885a-dbd2-4968-84a9-ef8da610b698", "0cd10475-0f3d-4995-9bad-c5e6591d804c" });

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
                    { 6, 2, "https://example.com/minecraft/image1.jpg" },
                    { 7, 2, "https://example.com/minecraft/image2.jpg" },
                    { 8, 2, "https://example.com/minecraft/image3.jpg" },
                    { 9, 2, "https://example.com/minecraft/image4.jpg" },
                    { 10, 2, "https://example.com/minecraft/image5.jpg" },
                    { 11, 3, "https://example.com/thewitcher3/image1.jpg" },
                    { 12, 3, "https://example.com/thewitcher3/image2.jpg" },
                    { 13, 3, "https://example.com/thewitcher3/image3.jpg" },
                    { 14, 3, "https://example.com/thewitcher3/image4.jpg" },
                    { 15, 3, "https://example.com/thewitcher3/image5.jpg" },
                    { 16, 4, "https://res.cloudinary.com/danedskby/image/upload/v1687547912/VideoGameShop/DemonSoul/gAP2DGRWpFSehL2GDrcsPL_ienhqh.jpg" },
                    { 17, 4, "https://res.cloudinary.com/danedskby/image/upload/v1687547907/VideoGameShop/DemonSoul/p3BNVCDOeLpb3bWAptk2Hi2t_v4hfbq.webp" },
                    { 18, 4, "https://res.cloudinary.com/danedskby/image/upload/v1687547904/VideoGameShop/DemonSoul/demonssouls-review-blogroll-1605559895476_160w_z5fsmg.jpg" },
                    { 19, 4, "https://res.cloudinary.com/danedskby/image/upload/v1687547904/VideoGameShop/DemonSoul/demonssouls-review-blogroll-1605559895476_160w_z5fsmg.jpg" },
                    { 20, 4, "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/DemonSoul/demons-souls-penetrator.large_vz9tfp.jpg" },
                    { 21, 5, "https://example.com/ratchetandclank/image1.jpg" },
                    { 22, 5, "https://example.com/ratchetandclank/image2.jpg" },
                    { 23, 5, "https://example.com/ratchetandclank/image3.jpg" },
                    { 24, 5, "https://example.com/ratchetandclank/image4.jpg" },
                    { 25, 5, "https://example.com/ratchetandclank/image5.jpg" },
                    { 26, 6, "https://example.com/returnal/image1.jpg" },
                    { 27, 6, "https://example.com/returnal/image2.jpg" },
                    { 28, 6, "https://example.com/returnal/image3.jpg" },
                    { 29, 6, "https://example.com/returnal/image4.jpg" },
                    { 30, 6, "https://example.com/returnal/image5.jpg" },
                    { 31, 7, "https://example.com/lastofus2/image1.jpg" },
                    { 32, 7, "https://example.com/lastofus2/image2.jpg" },
                    { 33, 7, "https://example.com/lastofus2/image3.jpg" },
                    { 34, 7, "https://example.com/lastofus2/image4.jpg" },
                    { 35, 7, "https://example.com/lastofus2/image5.jpg" },
                    { 36, 8, "https://example.com/godofwar/image1.jpg" },
                    { 37, 8, "https://example.com/godofwar/image2.jpg" },
                    { 38, 8, "https://example.com/godofwar/image3.jpg" },
                    { 39, 8, "https://example.com/godofwar/image4.jpg" },
                    { 40, 8, "https://example.com/godofwar/image5.jpg" },
                    { 41, 9, "https://example.com/uncharted4/image1.jpg" },
                    { 42, 9, "https://example.com/uncharted4/image2.jpg" },
                    { 43, 9, "https://example.com/uncharted4/image3.jpg" },
                    { 44, 9, "https://example.com/uncharted4/image4.jpg" },
                    { 45, 9, "https://example.com/uncharted4/image5.jpg" },
                    { 46, 10, "https://example.com/forzahorizon4/image1.jpg" },
                    { 47, 10, "https://example.com/forzahorizon4/image2.jpg" },
                    { 48, 10, "https://example.com/forzahorizon4/image3.jpg" },
                    { 49, 10, "https://example.com/forzahorizon4/image4.jpg" },
                    { 50, 10, "https://example.com/forzahorizon4/image5.jpg" },
                    { 51, 11, "https://example.com/halo5/image1.jpg" },
                    { 52, 11, "https://example.com/halo5/image2.jpg" },
                    { 53, 11, "https://example.com/halo5/image3.jpg" },
                    { 54, 11, "https://example.com/halo5/image4.jpg" },
                    { 55, 11, "https://example.com/halo5/image5.jpg" },
                    { 56, 12, "https://example.com/gearsofwar4/image1.jpg" },
                    { 57, 12, "https://example.com/gearsofwar4/image2.jpg" },
                    { 58, 12, "https://example.com/gearsofwar4/image3.jpg" },
                    { 59, 12, "https://example.com/gearsofwar4/image4.jpg" },
                    { 60, 12, "https://example.com/gearsofwar4/image5.jpg" },
                    { 61, 13, "https://example.com/assassinscreedvalhalla/image1.jpg" },
                    { 62, 13, "https://example.com/assassinscreedvalhalla/image2.jpg" },
                    { 63, 13, "https://example.com/assassinscreedvalhalla/image3.jpg" },
                    { 64, 13, "https://example.com/assassinscreedvalhalla/image4.jpg" },
                    { 65, 13, "https://example.com/assassinscreedvalhalla/image5.jpg" },
                    { 66, 14, "https://example.com/deathstranding/image1.jpg" },
                    { 67, 14, "https://example.com/deathstranding/image2.jpg" },
                    { 68, 14, "https://example.com/deathstranding/image3.jpg" },
                    { 69, 14, "https://example.com/deathstranding/image4.jpg" },
                    { 70, 14, "https://example.com/deathstranding/image5.jpg" },
                    { 71, 15, "https://example.com/grandtheftautoV/image1.jpg" },
                    { 72, 15, "https://example.com/grandtheftautoV/image2.jpg" },
                    { 73, 15, "https://example.com/grandtheftautoV/image3.jpg" },
                    { 74, 15, "https://example.com/grandtheftautoV/image4.jpg" },
                    { 75, 15, "https://example.com/grandtheftautoV/image5.jpg" },
                    { 76, 16, "https://example.com/spidermanmilesmorales/image1.jpg" },
                    { 77, 16, "https://example.com/spidermanmilesmorales/image2.jpg" },
                    { 78, 16, "https://example.com/spidermanmilesmorales/image3.jpg" },
                    { 79, 16, "https://example.com/spidermanmilesmorales/image4.jpg" },
                    { 80, 16, "https://example.com/spidermanmilesmorales/image5.jpg" },
                    { 81, 17, "https://example.com/residentevilvillage/image1.jpg" },
                    { 82, 17, "https://example.com/residentevilvillage/image2.jpg" },
                    { 83, 17, "https://example.com/residentevilvillage/image3.jpg" },
                    { 84, 17, "https://example.com/residentevilvillage/image4.jpg" },
                    { 85, 17, "https://example.com/residentevilvillage/image5.jpg" },
                    { 86, 18, "https://example.com/demonslayerhinokamichronicles/image1.jpg" },
                    { 87, 18, "https://example.com/demonslayerhinokamichronicles/image2.jpg" },
                    { 88, 18, "https://example.com/demonslayerhinokamichronicles/image3.jpg" },
                    { 89, 18, "https://example.com/demonslayerhinokamichronicles/image4.jpg" },
                    { 90, 18, "https://example.com/demonslayerhinokamichronicles/image5.jpg" },
                    { 91, 19, "https://example.com/horizonforbiddenwest/image1.jpg" },
                    { 92, 19, "https://example.com/horizonforbiddenwest/image2.jpg" },
                    { 93, 19, "https://example.com/horizonforbiddenwest/image3.jpg" },
                    { 94, 19, "https://example.com/horizonforbiddenwest/image4.jpg" },
                    { 95, 19, "https://example.com/horizonforbiddenwest/image5.jpg" },
                    { 96, 20, "https://example.com/horizonforbiddenwest/image1.jpg" },
                    { 97, 20, "https://example.com/horizonforbiddenwest/image2.jpg" },
                    { 98, 20, "https://example.com/horizonforbiddenwest/image3.jpg" },
                    { 99, 20, "https://example.com/horizonforbiddenwest/image4.jpg" },
                    { 100, 20, "https://example.com/horizonforbiddenwest/image5.jpg" },
                    { 101, 21, "https://example.com/horizonforbiddenwest/image1.jpg" },
                    { 102, 21, "https://example.com/horizonforbiddenwest/image2.jpg" },
                    { 103, 21, "https://example.com/horizonforbiddenwest/image3.jpg" },
                    { 104, 21, "https://example.com/horizonforbiddenwest/image4.jpg" },
                    { 105, 21, "https://example.com/horizonforbiddenwest/image5.jpg" },
                    { 106, 22, "https://example.com/skyrim/image1.jpg" },
                    { 107, 22, "https://example.com/skyrim/image2.jpg" },
                    { 108, 22, "https://example.com/skyrim/image3.jpg" },
                    { 109, 22, "https://example.com/skyrim/image4.jpg" },
                    { 110, 22, "https://example.com/skyrim/image5.jpg" },
                    { 111, 23, "https://example.com/worldofwarcraft/image1.jpg" },
                    { 112, 23, "https://example.com/worldofwarcraft/image2.jpg" },
                    { 113, 23, "https://example.com/worldofwarcraft/image3.jpg" },
                    { 114, 23, "https://example.com/worldofwarcraft/image4.jpg" },
                    { 115, 23, "https://example.com/worldofwarcraft/image5.jpg" },
                    { 116, 24, "https://example.com/fallout4/image1.jpg" },
                    { 117, 24, "https://example.com/fallout4/image2.jpg" },
                    { 118, 24, "https://example.com/fallout4/image3.jpg" },
                    { 119, 24, "https://example.com/fallout4/image4.jpg" },
                    { 120, 24, "https://example.com/fallout4/image5.jpg" },
                    { 121, 25, "https://example.com/horizonforbiddenwest/image1.jpg" },
                    { 122, 25, "https://example.com/horizonforbiddenwest/image2.jpg" },
                    { 123, 25, "https://example.com/horizonforbiddenwest/image3.jpg" },
                    { 124, 25, "https://example.com/horizonforbiddenwest/image4.jpg" },
                    { 125, 25, "https://example.com/horizonforbiddenwest/image5.jpg" },
                    { 126, 26, "https://example.com/callofdutywarzone/image1.jpg" },
                    { 127, 26, "https://example.com/callofdutywarzone/image2.jpg" },
                    { 128, 26, "https://example.com/callofdutywarzone/image3.jpg" },
                    { 129, 26, "https://example.com/callofdutywarzone/image4.jpg" },
                    { 130, 26, "https://example.com/callofdutywarzone/image5.jpg" },
                    { 131, 27, "https://example.com/fortnite/image1.jpg" },
                    { 132, 27, "https://example.com/fortnite/image2.jpg" },
                    { 133, 27, "https://example.com/fortnite/image3.jpg" },
                    { 134, 27, "https://example.com/fortnite/image4.jpg" },
                    { 135, 27, "https://example.com/fortnite/image5.jpg" }
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
