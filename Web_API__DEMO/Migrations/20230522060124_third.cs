using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_API__DEMO.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be46848a-d0d0-4ea9-aab1-d71d6f968ffb", "AQAAAAEAACcQAAAAEP9+/F09xx9sMbD6oAGfBOo18F5HYSU29LRQrWEZ4xMF90Qsi9E3ObzT14JXzlpydA==", "64a6abce-ff1d-4edc-b6c9-2a438c4cc438" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c45ad826-4997-4628-9b7d-003ddab83157", null, "8ddf172c-ed97-49cb-8d83-14e35b12c5ca" });
        }
    }
}
