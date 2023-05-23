using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_API__DEMO.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "2", "HR", "User" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "1", "Admin", "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dad0c57b-2a03-4fa5-a041-330b9780820f", "AQAAAAEAACcQAAAAEITIHUdmp4m6uq3k4yK/TSph9y8e31A/2sqR9tT2A+gnw4HzeKiAkGsO39iV2m4akw==", "1eaf829c-134b-4d0b-bb2f-cb38c9ba879f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60f3ef4c-8af6-4247-9046-e541ae1df791", "AQAAAAEAACcQAAAAEN+1JCA9tEkZKJ5B6XJLZpultD37/h6U8xGM63LPfeOFOJt+BaEbJBEnJMqALMdFtg==", "e0ef98bd-37c8-4135-8a47-befa615a1f37" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "300105e0-c810-487c-89fa-c1cf3dbc7bdd", "AQAAAAEAACcQAAAAEHqSEPHOcUNFKh0enBAeYSWsdDNMHfWKa2hLsUxkXpAQfOWIPwEO7ci/iGfZhpYIlg==", "e823e452-df66-4c42-9193-d425e0dcb8e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8867b92-8226-426a-91ae-053ec34d656d", "AQAAAAEAACcQAAAAECwVvEs2Nz7UwcJziAG4BHrdajSQnT7aJeWhgLVQ5LiQ2DqYH4IJdWLmZkCxrqALqw==", "59279a58-1510-486e-a47e-f5ad8db5a7b5" });
        }
    }
}
