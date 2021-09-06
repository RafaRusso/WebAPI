using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class automapper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColabDepartamento_Colabs_ColaboradoresId",
                table: "ColabDepartamento");

            migrationBuilder.DropForeignKey(
                name: "FK_ColabGrupo_Colabs_ColaboradoresId",
                table: "ColabGrupo");

            migrationBuilder.RenameColumn(
                name: "ColaboradoresId",
                table: "ColabGrupo",
                newName: "ColabsId");

            migrationBuilder.RenameColumn(
                name: "ColaboradoresId",
                table: "ColabDepartamento",
                newName: "ColabsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ColabDepartamento_Colabs_ColabsId",
                table: "ColabDepartamento",
                column: "ColabsId",
                principalTable: "Colabs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColabGrupo_Colabs_ColabsId",
                table: "ColabGrupo",
                column: "ColabsId",
                principalTable: "Colabs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColabDepartamento_Colabs_ColabsId",
                table: "ColabDepartamento");

            migrationBuilder.DropForeignKey(
                name: "FK_ColabGrupo_Colabs_ColabsId",
                table: "ColabGrupo");

            migrationBuilder.RenameColumn(
                name: "ColabsId",
                table: "ColabGrupo",
                newName: "ColaboradoresId");

            migrationBuilder.RenameColumn(
                name: "ColabsId",
                table: "ColabDepartamento",
                newName: "ColaboradoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_ColabDepartamento_Colabs_ColaboradoresId",
                table: "ColabDepartamento",
                column: "ColaboradoresId",
                principalTable: "Colabs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColabGrupo_Colabs_ColaboradoresId",
                table: "ColabGrupo",
                column: "ColaboradoresId",
                principalTable: "Colabs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
