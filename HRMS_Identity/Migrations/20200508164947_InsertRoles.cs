using Microsoft.EntityFrameworkCore.Migrations;

namespace HRMS_Identity.Migrations
{
    public partial class InsertRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8ef8a020-2cad-42a7-9331-46041ee4af84", "a1566649-1e4a-4a57-b5ae-a487df7284bf", "Pracownik HR", null },
                    { "d931fb37-aae2-47f6-b50f-5489dc3b5d82", "bfdcdaad-6ddd-49ad-8ffd-1f715a00518a", "Administrator", null },
                    { "77cbe8b3-efe8-4666-84e9-db92104ead59", "9918375c-d120-4035-8870-a37b5ce43042", "Manager", null },
                    { "4371e1dd-466e-45cc-9308-04c3a5338a7f", "0102f4b5-6eab-4b7d-9c33-62aa0d379ebb", "Pracownik", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4371e1dd-466e-45cc-9308-04c3a5338a7f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77cbe8b3-efe8-4666-84e9-db92104ead59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ef8a020-2cad-42a7-9331-46041ee4af84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d931fb37-aae2-47f6-b50f-5489dc3b5d82");
        }
    }
}
