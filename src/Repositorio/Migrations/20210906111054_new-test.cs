using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class newtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColabDepartamento");

            migrationBuilder.DropTable(
                name: "ColabGrupo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColabDepartamento",
                columns: table => new
                {
                    ColaboradoresId = table.Column<int>(type: "integer", nullable: false),
                    DepartamentosId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColabDepartamento", x => new { x.ColaboradoresId, x.DepartamentosId });
                    table.ForeignKey(
                        name: "FK_ColabDepartamento_Colabs_ColaboradoresId",
                        column: x => x.ColaboradoresId,
                        principalTable: "Colabs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColabDepartamento_Departamentos_DepartamentosId",
                        column: x => x.DepartamentosId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColabGrupo",
                columns: table => new
                {
                    ColaboradoresId = table.Column<int>(type: "integer", nullable: false),
                    GruposId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColabGrupo", x => new { x.ColaboradoresId, x.GruposId });
                    table.ForeignKey(
                        name: "FK_ColabGrupo_Colabs_ColaboradoresId",
                        column: x => x.ColaboradoresId,
                        principalTable: "Colabs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColabGrupo_Grupos_GruposId",
                        column: x => x.GruposId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColabDepartamento_DepartamentosId",
                table: "ColabDepartamento",
                column: "DepartamentosId");

            migrationBuilder.CreateIndex(
                name: "IX_ColabGrupo_GruposId",
                table: "ColabGrupo",
                column: "GruposId");
        }
    }
}
