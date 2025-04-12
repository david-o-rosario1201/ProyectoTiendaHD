using System.ComponentModel.DataAnnotations;

namespace ProyectoTiendaHD.Modelos;

public class CoincidenciaPropuestaValor
{
	[Key]
	public int CoincidenciaId { get; set; }
	public int ClienteId { get; set; }
	public string Descripcion { get; set; }
}
