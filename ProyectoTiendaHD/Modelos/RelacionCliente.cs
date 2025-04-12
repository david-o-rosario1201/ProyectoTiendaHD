using System.ComponentModel.DataAnnotations;

namespace TiendaHDProject.Modelos;

public class RelacionCliente
{
	[Key]
	public int RelacionClienteId { get; set; }
    public string Descripcion { get; set; }
}
