using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRM.Web.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {   
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b347e7c-5b3d-4ca7-966e-3f0f0801b8b0", "0fdc81e4-f863-4079-920b-2aac4e3b3203", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc38fe4f-d200-44ee-83c2-ffd6f1395291", "94459506-506d-447f-824d-e243ece1fd90", "HR", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b347e7c-5b3d-4ca7-966e-3f0f0801b8b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc38fe4f-d200-44ee-83c2-ffd6f1395291");

            migrationBuilder.CreateTable(
                name: "IdentityRole<string>",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole<string>", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "IdentityRole<string>",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a62d779-b1e3-409f-8b34-7ed6db7275b3", "5ebfcc97-c7ae-4c13-bb84-92a817982f35", "Admin", null });

            migrationBuilder.InsertData(
                table: "IdentityRole<string>",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b29a7e07-c528-497d-8675-458733328916", "4652b3a9-04ac-46d0-9cbf-86d4380ac712", "HR", null });
        }
    }
}
