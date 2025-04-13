using ProyectoTiendaHD.Modelos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoTiendaHD.Modelos;

public class ModeloNegocio
{
	[Key]
	public int ModeloNegocioId { get; set; }

	//[ForeignKey("PropuestaValor")]
    public int PropuestaValorId { get; set; }

	//[ForeignKey("SegmentoMercado")]
    public int SegmentoMercadoId { get; set; }

    public PropuestaValor? PropuestaValor { get; set; }
    public SegmentoMercado? SegmentoMercado { get; set; }

    [ForeignKey("ModeloNegocioId")]
	public ICollection<CanalDistribucion> Canales { get; set; } = new List<CanalDistribucion>();

	[ForeignKey("ModeloNegocioId")]
	public ICollection<ActividadClave> Actividades { get; set; } = new List<ActividadClave>();

	[ForeignKey("ModeloNegocioId")]
	public ICollection<RelacionCliente> Relaciones { get; set; } = new List<RelacionCliente>();

	[ForeignKey("ModeloNegocioId")]
	public ICollection<IngresoPrecio> Ingresos { get; set; } = new List<IngresoPrecio>();
}
