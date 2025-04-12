using System.ComponentModel.DataAnnotations;

namespace ProyectoTiendaHD.Modelos;

public class CoincidenciaRelacionCliente
{
	[Key]
	public int CoincidenciaId { get; set; }
	public int ClienteId { get; set; }
	public string Descripcion { get; set; }
}
