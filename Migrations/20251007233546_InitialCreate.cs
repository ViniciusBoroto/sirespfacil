using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SirespFacil.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Condutas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condutas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Justificativas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Justificativas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lateralidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lateralidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    CRM = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sexo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposCriterioAutorizacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposCriterioAutorizacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposExames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposExames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    NIR = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    CodigoSIRESP = table.Column<string>(type: "TEXT", nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    SexoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Idade = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_Sexo_SexoId",
                        column: x => x.SexoId,
                        principalTable: "Sexo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CriteriosDeAutorizacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CaminhoArquivo = table.Column<string>(type: "TEXT", nullable: false),
                    TipoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriteriosDeAutorizacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriteriosDeAutorizacao_TiposCriterioAutorizacao_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TiposCriterioAutorizacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CaminhosArquivos = table.Column<string>(type: "TEXT", nullable: false),
                    Data = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exames_TiposExames_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TiposExames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Solicitantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UnidadeId = table.Column<int>(type: "INTEGER", nullable: false),
                    MedicoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Solicitantes_Medicos_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Solicitantes_Unidades_UnidadeId",
                        column: x => x.UnidadeId,
                        principalTable: "Unidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RessonanciasMagneticas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CriterioDeAutorizacaoId = table.Column<int>(type: "INTEGER", nullable: false),
                    SolicitanteId = table.Column<int>(type: "INTEGER", nullable: false),
                    PacienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Peso = table.Column<double>(type: "REAL", nullable: false),
                    Altura = table.Column<double>(type: "REAL", nullable: false),
                    CircunferenciaAbdominal = table.Column<double>(type: "REAL", nullable: false),
                    ValorUreia = table.Column<double>(type: "REAL", nullable: false),
                    ValorCreatinina = table.Column<double>(type: "REAL", nullable: false),
                    Motivo = table.Column<string>(type: "TEXT", nullable: false),
                    CondutaId = table.Column<int>(type: "INTEGER", nullable: false),
                    JustificativaId = table.Column<int>(type: "INTEGER", nullable: false),
                    DescricaoDiagnostico = table.Column<string>(type: "TEXT", nullable: false),
                    CIDPrincipal = table.Column<string>(type: "TEXT", nullable: false),
                    CIDSecundario = table.Column<string>(type: "TEXT", nullable: false),
                    CIDCausasAssociadas = table.Column<string>(type: "TEXT", nullable: false),
                    Data = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    OutroExame = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RessonanciasMagneticas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RessonanciasMagneticas_Condutas_CondutaId",
                        column: x => x.CondutaId,
                        principalTable: "Condutas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RessonanciasMagneticas_CriteriosDeAutorizacao_CriterioDeAutorizacaoId",
                        column: x => x.CriterioDeAutorizacaoId,
                        principalTable: "CriteriosDeAutorizacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RessonanciasMagneticas_Justificativas_JustificativaId",
                        column: x => x.JustificativaId,
                        principalTable: "Justificativas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RessonanciasMagneticas_Pacientes_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RessonanciasMagneticas_Solicitantes_SolicitanteId",
                        column: x => x.SolicitanteId,
                        principalTable: "Solicitantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExameRessonanciaMagnetica",
                columns: table => new
                {
                    ExamesId = table.Column<int>(type: "INTEGER", nullable: false),
                    RessonanciaMagneticasId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExameRessonanciaMagnetica", x => new { x.ExamesId, x.RessonanciaMagneticasId });
                    table.ForeignKey(
                        name: "FK_ExameRessonanciaMagnetica_Exames_ExamesId",
                        column: x => x.ExamesId,
                        principalTable: "Exames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExameRessonanciaMagnetica_RessonanciasMagneticas_RessonanciaMagneticasId",
                        column: x => x.RessonanciaMagneticasId,
                        principalTable: "RessonanciasMagneticas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExameSolicitados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Exame = table.Column<string>(type: "TEXT", nullable: false),
                    Sedacao = table.Column<bool>(type: "INTEGER", nullable: false),
                    ClassificacaoAsaId = table.Column<int>(type: "INTEGER", nullable: false),
                    LateralidadeId = table.Column<int>(type: "INTEGER", nullable: false),
                    RessonanciaMagneticaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExameSolicitados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExameSolicitados_ClassificacaoAsa_ClassificacaoAsaId",
                        column: x => x.ClassificacaoAsaId,
                        principalTable: "ClassificacaoAsa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExameSolicitados_Lateralidades_LateralidadeId",
                        column: x => x.LateralidadeId,
                        principalTable: "Lateralidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExameSolicitados_RessonanciasMagneticas_RessonanciaMagneticaId",
                        column: x => x.RessonanciaMagneticaId,
                        principalTable: "RessonanciasMagneticas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImplantesMetalicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dispositivo = table.Column<string>(type: "TEXT", nullable: false),
                    TempoDeUso = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    Material = table.Column<string>(type: "TEXT", nullable: false),
                    Localizacao = table.Column<string>(type: "TEXT", nullable: false),
                    RessonanciaMagneticaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImplantesMetalicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImplantesMetalicos_RessonanciasMagneticas_RessonanciaMagneticaId",
                        column: x => x.RessonanciaMagneticaId,
                        principalTable: "RessonanciasMagneticas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CriteriosDeAutorizacao_TipoId",
                table: "CriteriosDeAutorizacao",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_ExameRessonanciaMagnetica_RessonanciaMagneticasId",
                table: "ExameRessonanciaMagnetica",
                column: "RessonanciaMagneticasId");

            migrationBuilder.CreateIndex(
                name: "IX_Exames_TipoId",
                table: "Exames",
                column: "TipoId");

            migrationBuilder.CreateIndex(
                name: "IX_ExameSolicitados_ClassificacaoAsaId",
                table: "ExameSolicitados",
                column: "ClassificacaoAsaId");

            migrationBuilder.CreateIndex(
                name: "IX_ExameSolicitados_LateralidadeId",
                table: "ExameSolicitados",
                column: "LateralidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_ExameSolicitados_RessonanciaMagneticaId",
                table: "ExameSolicitados",
                column: "RessonanciaMagneticaId");

            migrationBuilder.CreateIndex(
                name: "IX_ImplantesMetalicos_RessonanciaMagneticaId",
                table: "ImplantesMetalicos",
                column: "RessonanciaMagneticaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_SexoId",
                table: "Pacientes",
                column: "SexoId");

            migrationBuilder.CreateIndex(
                name: "IX_RessonanciasMagneticas_CondutaId",
                table: "RessonanciasMagneticas",
                column: "CondutaId");

            migrationBuilder.CreateIndex(
                name: "IX_RessonanciasMagneticas_CriterioDeAutorizacaoId",
                table: "RessonanciasMagneticas",
                column: "CriterioDeAutorizacaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RessonanciasMagneticas_JustificativaId",
                table: "RessonanciasMagneticas",
                column: "JustificativaId");

            migrationBuilder.CreateIndex(
                name: "IX_RessonanciasMagneticas_PacienteId",
                table: "RessonanciasMagneticas",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_RessonanciasMagneticas_SolicitanteId",
                table: "RessonanciasMagneticas",
                column: "SolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitantes_MedicoId",
                table: "Solicitantes",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Solicitantes_UnidadeId",
                table: "Solicitantes",
                column: "UnidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExameRessonanciaMagnetica");

            migrationBuilder.DropTable(
                name: "ExameSolicitados");

            migrationBuilder.DropTable(
                name: "ImplantesMetalicos");

            migrationBuilder.DropTable(
                name: "Exames");

            migrationBuilder.DropTable(
                name: "ClassificacaoAsa");

            migrationBuilder.DropTable(
                name: "Lateralidades");

            migrationBuilder.DropTable(
                name: "RessonanciasMagneticas");

            migrationBuilder.DropTable(
                name: "TiposExames");

            migrationBuilder.DropTable(
                name: "Condutas");

            migrationBuilder.DropTable(
                name: "CriteriosDeAutorizacao");

            migrationBuilder.DropTable(
                name: "Justificativas");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Solicitantes");

            migrationBuilder.DropTable(
                name: "TiposCriterioAutorizacao");

            migrationBuilder.DropTable(
                name: "Sexo");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Unidades");
        }
    }
}
