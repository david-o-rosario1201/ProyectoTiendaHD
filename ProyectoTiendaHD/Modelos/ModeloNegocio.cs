namespace TiendaHDProject.Modelos;

public class ModeloNegocio
{
    public int ModeloNegocioId { get; set; }
    public int PropuestaValorId { get; set; }
    public int IngresoPrecioId { get; set; }
    public int SegmentoMercadoId { get; set; }

    public PropuestaValor PropuestaValor { get; set; }
    public IngresoPrecio IngresoPrecio { get; set; }
    public SegmentoMercado SegmentoMercado { get; set; }
    public List<DetalleModeloNegocioCanalDistribucion> Canales { get; set; }
    public List<DetalleModeloNegocioActividadClave> Actividades { get; set; }
    public List<DetalleModeloNegocioRelacionCliente> Relaciones { get; set; }
    public List<DetalleModeloNegocioIngresoPrecio> Ingresos { get; set; }
}
