using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class idade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "Colabs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "Colabs");

            migrationBuilder.AlterColumn<string>(
                name: "Idade",
                table: "Colabs",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }
    }
}
