using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NotesMinimalAPI.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    timeStamp = table.Column<string>(type: "text", nullable: false),
                    station = table.Column<string>(type: "text", nullable: false),
                    temperature = table.Column<decimal>(type: "numeric", nullable: false),
                    dewPoint = table.Column<decimal>(type: "numeric", nullable: false),
                    humidity = table.Column<byte>(type: "smallint", nullable: false),
                    windDirection = table.Column<string>(type: "text", nullable: false),
                    windSpeed = table.Column<decimal>(type: "numeric", nullable: false),
                    gust = table.Column<decimal>(type: "numeric", nullable: false),
                    pressure = table.Column<decimal>(type: "numeric", nullable: false),
                    precipitationRate = table.Column<decimal>(type: "numeric", nullable: false),
                    precipitationAcc = table.Column<decimal>(type: "numeric", nullable: false),
                    uv = table.Column<decimal>(type: "numeric", nullable: false),
                    solarIrradiation = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");
        }
    }
}
