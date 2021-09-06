using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class many2many : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColabId",
                table: "Grupos",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColabId",
                table: "Departamentos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_ColabId",
                table: "Grupos",
                column: "ColabId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_ColabId",
                table: "Departamentos",
                column: "ColabId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Colabs_ColabId",
                table: "Departamentos",
                column: "ColabId",
                principalTable: "Colabs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grupos_Colabs_ColabId",
                table: "Grupos",
                column: "ColabId",
                principalTable: "Colabs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Colabs_ColabId",
                table: "Departamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Grupos_Colabs_ColabId",
                table: "Grupos");

            migrationBuilder.DropIndex(
                name: "IX_Grupos_ColabId",
                table: "Grupos");

            migrationBuilder.DropIndex(
                name: "IX_Departamentos_ColabId",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "ColabId",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "ColabId",
                table: "Departamentos");
        }
    }
}
