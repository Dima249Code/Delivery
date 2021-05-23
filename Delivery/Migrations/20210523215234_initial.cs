using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Delivery.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReciverCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReciverAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    weight = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliveries");
        }
    }
}
