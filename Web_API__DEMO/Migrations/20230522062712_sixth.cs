using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_API__DEMO.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "Name",
                value: "User");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fb37d55-8be7-405b-b64f-eaa8e296d219", "AQAAAAEAACcQAAAAEMtvfZBdK4yOs4uVHWdqo/AVQ34V56ajSCev7TxlNZBSAswmSCbsl3VNtlBIj+ZteA==", "8b9dbe6d-2d70-4a26-835e-8910eff6b51c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8468245-4278-4bb6-ad82-25e7e1bf6ef1", "AQAAAAEAACcQAAAAEEIiIn19dcVFlB99gmUtRvl8UwAN3rffJVHhzQAzDSftNQCHlOp+X0roWwBsCogsYQ==", "db9be6eb-12b1-484c-9b82-9332eaeefdf6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330",
                column: "Name",
                value: "HR");

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
    }
}
