using Microsoft.EntityFrameworkCore.Migrations;

namespace Repositorio.Migrations
{
    public partial class GrupoDepartamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Departamento",
                table: "Colabs");

            migrationBuilder.DropColumn(
                name: "Grupo",
                table: "Colabs");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoColab",
                table: "Colabs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "Colabs",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GrupoColab",
                table: "Colabs",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Colabs",
                type: "integer",
                nullable: true);

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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Colabs_Grupos_GrupoId",
                table: "Colabs",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "DepartamentoColab",
                table: "Colabs");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Colabs");

            migrationBuilder.DropColumn(
                name: "GrupoColab",
                table: "Colabs");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Colabs");

            migrationBuilder.AddColumn<string>(
                name: "Departamento",
                table: "Colabs",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grupo",
                table: "Colabs",
                type: "text",
                nullable: true);
        }
    }
}
