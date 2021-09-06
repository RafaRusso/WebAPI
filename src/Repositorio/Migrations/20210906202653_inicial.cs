using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Data.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            

            migrationBuilder.CreateTable(
                name: "ColabGrupo",
                columns: table => new
                {
                    ColabsId = table.Column<int>(type: "integer", nullable: false),
                    GruposId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColabGrupo", x => new { x.ColabsId, x.GruposId });
                    table.ForeignKey(
                        name: "FK_ColabGrupo_Colabs_ColabsId",
                        column: x => x.ColabsId,
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
                name: "IX_ColabGrupo_GruposId",
                table: "ColabGrupo",
                column: "GruposId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColabDepartamento");

            migrationBuilder.DropTable(
                name: "ColabGrupo");

            migrationBuilder.DropTable(
                name: "Departamentos");

            migrationBuilder.DropTable(
                name: "Colabs");

            migrationBuilder.DropTable(
                name: "Grupos");
        }
    }
}
