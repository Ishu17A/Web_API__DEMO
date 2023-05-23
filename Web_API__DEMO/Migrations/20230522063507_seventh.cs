using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_API__DEMO.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "634a60ec-96bc-4f37-937f-27ba52f58d41" },
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "c80d49e8-a97c-45e6-babf-0760a6b86814" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634a60ec-96bc-4f37-937f-27ba52f58d41",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86ac3bca-fa36-485f-ad2f-50e699cbbda0", "AQAAAAEAACcQAAAAEIJZUmADo3QAEYleFKRTW2YjlFIGSZogXx+RSuIF7817xaA+FeQH6pMNH/3im3fODw==", "81f2f94f-3977-43d0-a077-242b2d4eb172" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c80d49e8-a97c-45e6-babf-0760a6b86814",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1ce90f8-9dfa-4251-98d7-606570101c49", "AQAAAAEAACcQAAAAEL2arm6gD6Kgs6fJQ9BkISI/tWaB6pmi9JlgM24VTZKOD+28+xpJaS3SqesO0wXOfw==", "2bfecb1c-4286-4701-af51-d207d8912731" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "634a60ec-96bc-4f37-937f-27ba52f58d41" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7b013f0-5201-4317-abd8-c211f91b7330", "c80d49e8-a97c-45e6-babf-0760a6b86814" });

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
    }
}
