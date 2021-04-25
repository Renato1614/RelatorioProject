using Microsoft.EntityFrameworkCore.Migrations;

namespace RelatorioProject.Migrations
{
    public partial class Destino : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_relatorio",
                table: "relatorio");

            migrationBuilder.RenameTable(
                name: "relatorio",
                newName: "Relatorio");

            migrationBuilder.AddColumn<string>(
                name: "Destino",
                table: "Relatorio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Relatorio",
                table: "Relatorio",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Relatorio",
                table: "Relatorio");

            migrationBuilder.DropColumn(
                name: "Destino",
                table: "Relatorio");

            migrationBuilder.RenameTable(
                name: "Relatorio",
                newName: "relatorio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_relatorio",
                table: "relatorio",
                column: "Id");
        }
    }
}
