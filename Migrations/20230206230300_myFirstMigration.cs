using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DeliveryAPI.Migrations
{
    /// <inheritdoc />
    public partial class myFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", maxLength: 100, nullable: false),
                    PhoneNumberCostumer = table.Column<string>(type: "text", maxLength: 9, nullable: false),
                    Email = table.Column<string>(type: "text", maxLength: 120, nullable: false),
                    Address = table.Column<string>(type: "text", maxLength: 120, nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "Name", "PhoneNumberCostumer", "Status" },
                values: new object[,]
                {
                    { 1, "La Union", "albertromero.edu.sv", "Albert Romero", "2345-2343", true },
                    { 2, "San Miguel", "albalopez.edu.sv", "Alba Lopez", "2040-2040", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
