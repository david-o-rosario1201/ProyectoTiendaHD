using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoTiendaHD.Migrations
{
    /// <inheritdoc />
    public partial class cliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_SegmentoMercado_SegmentoMercadoId",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_SegmentoMercadoId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "SegmentoMercadoId",
                table: "Cliente");

            migrationBuilder.AlterColumn<double>(
                name: "PorcentajeCoincidencias",
                table: "Cliente",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Edad",
                table: "Cliente",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PorcentajeCoincidencias",
                table: "Cliente",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Edad",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SegmentoMercadoId",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_SegmentoMercadoId",
                table: "Cliente",
                column: "SegmentoMercadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_SegmentoMercado_SegmentoMercadoId",
                table: "Cliente",
                column: "SegmentoMercadoId",
                principalTable: "SegmentoMercado",
                principalColumn: "SegmentoMercadoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
