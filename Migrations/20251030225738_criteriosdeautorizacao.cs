using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SirespFacil.Migrations
{
    /// <inheritdoc />
    public partial class criteriosdeautorizacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExameSolicitados_ClassificacaoAsa_ClassificacaoAsaId",
                table: "ExameSolicitados");

            migrationBuilder.DropForeignKey(
                name: "FK_RessonanciasMagneticas_CriteriosDeAutorizacao_CriterioDeAutorizacaoId",
                table: "RessonanciasMagneticas");

            migrationBuilder.DropTable(
                name: "ClassificacaoAsa");

            migrationBuilder.DropIndex(
                name: "IX_RessonanciasMagneticas_CriterioDeAutorizacaoId",
                table: "RessonanciasMagneticas");

            migrationBuilder.DropIndex(
                name: "IX_ExameSolicitados_ClassificacaoAsaId",
                table: "ExameSolicitados");

            migrationBuilder.DropColumn(
                name: "CriterioDeAutorizacaoId",
                table: "RessonanciasMagneticas");

            migrationBuilder.RenameColumn(
                name: "ClassificacaoAsaId",
                table: "ExameSolicitados",
                newName: "ClassificacaoAsa");

            migrationBuilder.AddColumn<int>(
                name: "RessonanciaMagneticaId",
                table: "CriteriosDeAutorizacao",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RessonanciaMagticaId",
                table: "CriteriosDeAutorizacao",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CriteriosDeAutorizacao_RessonanciaMagneticaId",
                table: "CriteriosDeAutorizacao",
                column: "RessonanciaMagneticaId");

            migrationBuilder.AddForeignKey(
                name: "FK_CriteriosDeAutorizacao_RessonanciasMagneticas_RessonanciaMagneticaId",
                table: "CriteriosDeAutorizacao",
                column: "RessonanciaMagneticaId",
                principalTable: "RessonanciasMagneticas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CriteriosDeAutorizacao_RessonanciasMagneticas_RessonanciaMagneticaId",
                table: "CriteriosDeAutorizacao");

            migrationBuilder.DropIndex(
                name: "IX_CriteriosDeAutorizacao_RessonanciaMagneticaId",
                table: "CriteriosDeAutorizacao");

            migrationBuilder.DropColumn(
                name: "RessonanciaMagneticaId",
                table: "CriteriosDeAutorizacao");

            migrationBuilder.DropColumn(
                name: "RessonanciaMagticaId",
                table: "CriteriosDeAutorizacao");

            migrationBuilder.RenameColumn(
                name: "ClassificacaoAsa",
                table: "ExameSolicitados",
                newName: "ClassificacaoAsaId");

            migrationBuilder.AddColumn<int>(
                name: "CriterioDeAutorizacaoId",
                table: "RessonanciasMagneticas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ClassificacaoAsa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Classificacao = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificacaoAsa", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RessonanciasMagneticas_CriterioDeAutorizacaoId",
                table: "RessonanciasMagneticas",
                column: "CriterioDeAutorizacaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExameSolicitados_ClassificacaoAsaId",
                table: "ExameSolicitados",
                column: "ClassificacaoAsaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExameSolicitados_ClassificacaoAsa_ClassificacaoAsaId",
                table: "ExameSolicitados",
                column: "ClassificacaoAsaId",
                principalTable: "ClassificacaoAsa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RessonanciasMagneticas_CriteriosDeAutorizacao_CriterioDeAutorizacaoId",
                table: "RessonanciasMagneticas",
                column: "CriterioDeAutorizacaoId",
                principalTable: "CriteriosDeAutorizacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
