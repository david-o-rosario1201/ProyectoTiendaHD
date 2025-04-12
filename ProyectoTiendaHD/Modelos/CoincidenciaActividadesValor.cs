using System.ComponentModel.DataAnnotations;

namespace TiendaHDProject.Modelos;

public class CoincidenciaActividadesValor
{
	[Key]
	public int CoincidenciaId { get; set; }
	public int ClienteId { get; set; }
	public string Descripcion { get; set; }
}
