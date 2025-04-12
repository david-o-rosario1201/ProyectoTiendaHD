using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoTiendaHD.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PropuestaValor",
                columns: table => new
                {
                    PropuestaValorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropuestaValor", x => x.PropuestaValorId);
                });

            migrationBuilder.CreateTable(
                name: "SegmentoMercado",
                columns: table => new
                {
                    SegmentoMercadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SegmentoMercado", x => x.SegmentoMercadoId);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    SegmentoMercadoId = table.Column<int>(type: "int", nullable: false),
                    PorcentajeCoincidencias = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Cliente_SegmentoMercado_SegmentoMercadoId",
                        column: x => x.SegmentoMercadoId,
                        principalTable: "SegmentoMercado",
                        principalColumn: "SegmentoMercadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoincidenciaActividadesValor",
                columns: table => new
                {
                    CoincidenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoincidenciaActividadesValor", x => x.CoincidenciaId);
                    table.ForeignKey(
                        name: "FK_CoincidenciaActividadesValor_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoincidenciaCanalesDistribucion",
                columns: table => new
                {
                    CoincidenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoincidenciaCanalesDistribucion", x => x.CoincidenciaId);
                    table.ForeignKey(
                        name: "FK_CoincidenciaCanalesDistribucion_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoincidenciaIngresosPrecio",
                columns: table => new
                {
                    CoincidenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoincidenciaIngresosPrecio", x => x.CoincidenciaId);
                    table.ForeignKey(
                        name: "FK_CoincidenciaIngresosPrecio_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoincidenciaPropuestaValor",
                columns: table => new
                {
                    CoincidenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoincidenciaPropuestaValor", x => x.CoincidenciaId);
                    table.ForeignKey(
                        name: "FK_CoincidenciaPropuestaValor_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoincidenciaRelacionCliente",
                columns: table => new
                {
                    CoincidenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoincidenciaRelacionCliente", x => x.CoincidenciaId);
                    table.ForeignKey(
                        name: "FK_CoincidenciaRelacionCliente_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoincidenciaSegmentoMercado",
                columns: table => new
                {
                    CoincidenciaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoincidenciaSegmentoMercado", x => x.CoincidenciaId);
                    table.ForeignKey(
                        name: "FK_CoincidenciaSegmentoMercado_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gusto",
                columns: table => new
                {
                    GustoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gusto", x => x.GustoId);
                    table.ForeignKey(
                        name: "FK_Gusto_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActividadeClave",
                columns: table => new
                {
                    ActividadClaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeloNegocioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActividadeClave", x => x.ActividadClaveId);
                });

            migrationBuilder.CreateTable(
                name: "RecursoClave",
                columns: table => new
                {
                    RecursoClaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActividadClaveId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecursoClave", x => x.RecursoClaveId);
                    table.ForeignKey(
                        name: "FK_RecursoClave_ActividadeClave_ActividadClaveId",
                        column: x => x.ActividadClaveId,
                        principalTable: "ActividadeClave",
                        principalColumn: "ActividadClaveId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CanalDistribucion",
                columns: table => new
                {
                    CanalDistribucionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeloNegocioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanalDistribucion", x => x.CanalDistribucionId);
                });

            migrationBuilder.CreateTable(
                name: "IngresoPrecio",
                columns: table => new
                {
                    IngresoPrecioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeloNegocioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngresoPrecio", x => x.IngresoPrecioId);
                });

            migrationBuilder.CreateTable(
                name: "ModeloNegocio",
                columns: table => new
                {
                    ModeloNegocioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropuestaValorId = table.Column<int>(type: "int", nullable: false),
                    IngresoPrecioId = table.Column<int>(type: "int", nullable: false),
                    SegmentoMercadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeloNegocio", x => x.ModeloNegocioId);
                    table.ForeignKey(
                        name: "FK_ModeloNegocio_IngresoPrecio_IngresoPrecioId",
                        column: x => x.IngresoPrecioId,
                        principalTable: "IngresoPrecio",
                        principalColumn: "IngresoPrecioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModeloNegocio_PropuestaValor_PropuestaValorId",
                        column: x => x.PropuestaValorId,
                        principalTable: "PropuestaValor",
                        principalColumn: "PropuestaValorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModeloNegocio_SegmentoMercado_SegmentoMercadoId",
                        column: x => x.SegmentoMercadoId,
                        principalTable: "SegmentoMercado",
                        principalColumn: "SegmentoMercadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelacionCliente",
                columns: table => new
                {
                    RelacionClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeloNegocioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelacionCliente", x => x.RelacionClienteId);
                    table.ForeignKey(
                        name: "FK_RelacionCliente_ModeloNegocio_ModeloNegocioId",
                        column: x => x.ModeloNegocioId,
                        principalTable: "ModeloNegocio",
                        principalColumn: "ModeloNegocioId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActividadeClave_ModeloNegocioId",
                table: "ActividadeClave",
                column: "ModeloNegocioId");

            migrationBuilder.CreateIndex(
                name: "IX_CanalDistribucion_ModeloNegocioId",
                table: "CanalDistribucion",
                column: "ModeloNegocioId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_SegmentoMercadoId",
                table: "Cliente",
                column: "SegmentoMercadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CoincidenciaActividadesValor_ClienteId",
                table: "CoincidenciaActividadesValor",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_CoincidenciaCanalesDistribucion_ClienteId",
                table: "CoincidenciaCanalesDistribucion",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_CoincidenciaIngresosPrecio_ClienteId",
                table: "CoincidenciaIngresosPrecio",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_CoincidenciaPropuestaValor_ClienteId",
                table: "CoincidenciaPropuestaValor",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_CoincidenciaRelacionCliente_ClienteId",
                table: "CoincidenciaRelacionCliente",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_CoincidenciaSegmentoMercado_ClienteId",
                table: "CoincidenciaSegmentoMercado",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Gusto_ClienteId",
                table: "Gusto",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_IngresoPrecio_ModeloNegocioId",
                table: "IngresoPrecio",
                column: "ModeloNegocioId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloNegocio_IngresoPrecioId",
                table: "ModeloNegocio",
                column: "IngresoPrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloNegocio_PropuestaValorId",
                table: "ModeloNegocio",
                column: "PropuestaValorId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeloNegocio_SegmentoMercadoId",
                table: "ModeloNegocio",
                column: "SegmentoMercadoId");

            migrationBuilder.CreateIndex(
                name: "IX_RecursoClave_ActividadClaveId",
                table: "RecursoClave",
                column: "ActividadClaveId");

            migrationBuilder.CreateIndex(
                name: "IX_RelacionCliente_ModeloNegocioId",
                table: "RelacionCliente",
                column: "ModeloNegocioId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActividadeClave_ModeloNegocio_ModeloNegocioId",
                table: "ActividadeClave",
                column: "ModeloNegocioId",
                principalTable: "ModeloNegocio",
                principalColumn: "ModeloNegocioId");

            migrationBuilder.AddForeignKey(
                name: "FK_CanalDistribucion_ModeloNegocio_ModeloNegocioId",
                table: "CanalDistribucion",
                column: "ModeloNegocioId",
                principalTable: "ModeloNegocio",
                principalColumn: "ModeloNegocioId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngresoPrecio_ModeloNegocio_ModeloNegocioId",
                table: "IngresoPrecio",
                column: "ModeloNegocioId",
                principalTable: "ModeloNegocio",
                principalColumn: "ModeloNegocioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngresoPrecio_ModeloNegocio_ModeloNegocioId",
                table: "IngresoPrecio");

            migrationBuilder.DropTable(
                name: "CanalDistribucion");

            migrationBuilder.DropTable(
                name: "CoincidenciaActividadesValor");

            migrationBuilder.DropTable(
                name: "CoincidenciaCanalesDistribucion");

            migrationBuilder.DropTable(
                name: "CoincidenciaIngresosPrecio");

            migrationBuilder.DropTable(
                name: "CoincidenciaPropuestaValor");

            migrationBuilder.DropTable(
                name: "CoincidenciaRelacionCliente");

            migrationBuilder.DropTable(
                name: "CoincidenciaSegmentoMercado");

            migrationBuilder.DropTable(
                name: "Gusto");

            migrationBuilder.DropTable(
                name: "RecursoClave");

            migrationBuilder.DropTable(
                name: "RelacionCliente");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "ActividadeClave");

            migrationBuilder.DropTable(
                name: "ModeloNegocio");

            migrationBuilder.DropTable(
                name: "IngresoPrecio");

            migrationBuilder.DropTable(
                name: "PropuestaValor");

            migrationBuilder.DropTable(
                name: "SegmentoMercado");
        }
    }
}
