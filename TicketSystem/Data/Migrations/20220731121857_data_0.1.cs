using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketSystem.Data.Migrations
{
    public partial class data_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rezervation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PnrNo = table.Column<string>(type: "varchar(50)", nullable: true),
                    FirmaNo = table.Column<int>(type: "int", nullable: false),
                    KalkisNoktaID = table.Column<int>(type: "int", nullable: false),
                    VarisNoktaID = table.Column<int>(type: "int", nullable: false),
                    Guzergah = table.Column<string>(type: "varchar(500)", nullable: true),
                    KoltukNo = table.Column<string>(type: "varchar(10)", nullable: true),
                    Isim = table.Column<string>(type: "varchar(200)", nullable: true),
                    SoyIsim = table.Column<string>(type: "varchar(200)", nullable: true),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rezervation");
        }
    }
}
