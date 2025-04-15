using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoTiendaHD.Modelos;

public class Cliente
{
	[Key]
	public int ClienteId { get; set; }
    public string Nombre { get; set; }
    public int? Edad { get; set; }
    public double? PorcentajeCoincidencias { get; set; }

    [ForeignKey("ClienteId")]
	public ICollection<Gusto> DetallesGusto { get; set; } = new List<Gusto>();

	[ForeignKey("ClienteId")]
	public ICollection<CoincidenciaSegmentoMercado> CoincidenciasSegmento { get; set; } = new List<CoincidenciaSegmentoMercado>();

	[ForeignKey("ClienteId")]
	public ICollection<CoincidenciaPropuestaValor> CoincidenciasPropuestaValor { get; set; } = new List<CoincidenciaPropuestaValor>();

	[ForeignKey("ClienteId")]
	public ICollection<CoincidenciaCanalesDistribucion> CoincidenciasCanales { get; set; } = new List<CoincidenciaCanalesDistribucion>();

	[ForeignKey("ClienteId")]
	public ICollection<CoincidenciaIngresosPrecio> CoincidenciasIngresos { get; set; } = new List<CoincidenciaIngresosPrecio>();

	[ForeignKey("ClienteId")]
	public ICollection<CoincidenciaActividadesValor> CoincidenciasActividades { get; set; } = new List<CoincidenciaActividadesValor>();

	[ForeignKey("ClienteId")]
	public ICollection<CoincidenciaRelacionCliente> CoincidenciasRelaciones { get; set; } = new List<CoincidenciaRelacionCliente>();
}
