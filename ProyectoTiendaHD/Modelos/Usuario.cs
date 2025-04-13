using System.ComponentModel.DataAnnotations;

namespace ProyectoTiendaHD.Modelos;

public class Usuario
{
	[Key]
	public int UsuarioId { get; set; }

	public string Nombre { get; set; }
}
