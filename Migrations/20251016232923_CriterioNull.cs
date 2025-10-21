using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SirespFacil.Migrations
{
    /// <inheritdoc />
    public partial class CriterioNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RessonanciasMagneticas_Solicitantes_SolicitanteId",
                table: "RessonanciasMagneticas");

            migrationBuilder.AlterColumn<int>(
                name: "SolicitanteId",
                table: "RessonanciasMagneticas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_RessonanciasMagneticas_Solicitantes_SolicitanteId",
                table: "RessonanciasMagneticas",
                column: "SolicitanteId",
                principalTable: "Solicitantes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RessonanciasMagneticas_Solicitantes_SolicitanteId",
                table: "RessonanciasMagneticas");

            migrationBuilder.AlterColumn<int>(
                name: "SolicitanteId",
                table: "RessonanciasMagneticas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RessonanciasMagneticas_Solicitantes_SolicitanteId",
                table: "RessonanciasMagneticas",
                column: "SolicitanteId",
                principalTable: "Solicitantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
