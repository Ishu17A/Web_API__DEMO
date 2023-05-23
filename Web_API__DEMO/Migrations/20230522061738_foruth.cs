using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_API__DEMO.Migrations
{
    public partial class foruth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "300105e0-c810-487c-89fa-c1cf3dbc7bdd", "AQAAAAEAACcQAAAAEHqSEPHOcUNFKh0enBAeYSWsdDNMHfWKa2hLsUxkXpAQfOWIPwEO7ci/iGfZhpYIlg==", "e823e452-df66-4c42-9193-d425e0dcb8e1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c80d49e8-a97c-45e6-babf-0760a6b86814", 0, "d8867b92-8226-426a-91ae-053ec34d656d", "user@gmail.com", false, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAECwVvEs2Nz7UwcJziAG4BHrdajSQnT7aJeWhgLVQ5LiQ2DqYH4IJdWLmZkCxrqALqw==", null, false, "59279a58-1510-486e-a47e-f5ad8db5a7b5", false, "user@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be46848a-d0d0-4ea9-aab1-d71d6f968ffb", "AQAAAAEAACcQAAAAEP9+/F09xx9sMbD6oAGfBOo18F5HYSU29LRQrWEZ4xMF90Qsi9E3ObzT14JXzlpydA==", "64a6abce-ff1d-4edc-b6c9-2a438c4cc438" });
        }
    }
}
