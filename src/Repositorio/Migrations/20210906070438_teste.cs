using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colabs_Departamentos_DepartamentoId",
                table: "Colabs");

            migrationBuilder.DropForeignKey(
                name: "FK_Colabs_Grupos_GrupoId",
                table: "Colabs");

            migrationBuilder.DropIndex(
                name: "IX_Colabs_DepartamentoId",
                table: "Colabs");

            migrationBuilder.DropIndex(
                name: "IX_Colabs_GrupoId",
                table: "Colabs");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "test",
                table: "Colabs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Colabs_DepartamentoId",
                table: "Colabs",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colabs_GrupoId",
                table: "Colabs",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colabs_Departamentos_DepartamentoId",
                table: "Colabs",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Colabs_Grupos_GrupoId",
                table: "Colabs",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
