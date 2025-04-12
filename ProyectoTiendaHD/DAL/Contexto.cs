using Microsoft.EntityFrameworkCore;
using ProyectoTiendaHD.Modelos;
using TiendaHDProject.Modelos;

namespace ProyectoTiendaHD.DAL;

public class Contexto : DbContext
{
	public Contexto(DbContextOptions<Contexto> options) : base(options)
	{

	}

	public DbSet<ActividadClave> ActividadeClave { get; set; }
	public DbSet<CanalDistribucion> CanalDistribucion { get; set; }
	public DbSet<Cliente> Cliente { get; set; }
	public DbSet<CoincidenciaActividadesValor> CoincidenciaActividadesValor { get; set; }
	public DbSet<CoincidenciaCanalesDistribucion> CoincidenciaCanalesDistribucion { get; set; }
	public DbSet<CoincidenciaIngresosPrecio> CoincidenciaIngresosPrecio { get; set; }
	public DbSet<CoincidenciaPropuestaValor> CoincidenciaPropuestaValor { get; set; }
	public DbSet<CoincidenciaSegmentoMercado> CoincidenciaSegmentoMercado { get; set; }
	public DbSet<CoincidenciaRelacionCliente> CoincidenciaRelacionCliente { get; set; }
	public DbSet<Gusto> Gusto { get; set; }
	public DbSet<IngresoPrecio> IngresoPrecio { get; set; }
	public DbSet<ModeloNegocio> ModeloNegocio { get; set; }
	public DbSet<PropuestaValor> PropuestaValor { get; set; }
	public DbSet<RecursoClave> RecursoClave { get; set; }
	public DbSet<RelacionCliente> RelacionCliente { get; set; }
	public DbSet<SegmentoMercado> SegmentoMercado { get; set; }
}
