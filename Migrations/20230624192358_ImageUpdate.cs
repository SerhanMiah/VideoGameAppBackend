using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VideoGameBackend.Migrations
{
    /// <inheritdoc />
    public partial class ImageUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fa0c994c-52c0-4014-a3da-4f50a7f27643", "e776bc3c-6217-48c4-83df-e323c5341d78" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0f606c4-152f-4b49-b670-c1960e76a898");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa0c994c-52c0-4014-a3da-4f50a7f27643");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e776bc3c-6217-48c4-83df-e323c5341d78");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a518391d-655e-4317-805b-16e2c91fbe22", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "ShippingAddress", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20d08833-a866-421e-8e0e-ba95e249386d", 0, "8f50a0c0-6d55-41f9-b513-37e15f4014ec", new DateTime(1998, 6, 24, 19, 23, 58, 590, DateTimeKind.Utc).AddTicks(8860), "user@videogameshop.com", true, "Regular", "User", false, null, "USER@VIDEOGAMESHOP.COM", "USER", "AQAAAAIAAYagAAAAEAdwQfk4BiTf9KdgP3Yk+o091uXKQZMNyQT/Zq9Eylyu4Cphir6iiWv6+DqZCOyrGw==", null, false, "4a3fa8f7-da6f-4152-918b-fc14ad2b7d01", "User's address", false, "user" },
                    { "b8018cdd-903f-4275-9fbd-1086385ef339", 0, "c6da04ab-da9a-4e01-8454-7e422e58f5fe", new DateTime(1993, 6, 24, 19, 23, 58, 553, DateTimeKind.Utc).AddTicks(5390), "admin@videogameshop.com", true, "Admin", "User", false, null, "ADMIN@VIDEOGAMESHOP.COM", "ADMIN", "AQAAAAIAAYagAAAAEIDmIAk19Oc5KU3r3kr1VCo8+L7vSsdaiRSjwdmvC+xuwi4EpHx8qgDmCiSA3ALb2w==", null, false, "588d2ba6-3ce3-4d0a-9ae9-c27949a68f0e", "Admin's address", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a518391d-655e-4317-805b-16e2c91fbe22", "b8018cdd-903f-4275-9fbd-1086385ef339" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a518391d-655e-4317-805b-16e2c91fbe22", "b8018cdd-903f-4275-9fbd-1086385ef339" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20d08833-a866-421e-8e0e-ba95e249386d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a518391d-655e-4317-805b-16e2c91fbe22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8018cdd-903f-4275-9fbd-1086385ef339");

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fa0c994c-52c0-4014-a3da-4f50a7f27643", "e776bc3c-6217-48c4-83df-e323c5341d78" });
        }
    }
}
