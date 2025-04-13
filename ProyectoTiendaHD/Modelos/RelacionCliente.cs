using System.ComponentModel.DataAnnotations;

namespace ProyectoTiendaHD.Modelos;

public class RelacionCliente
{
	[Key]
	public int RelacionClienteId { get; set; }
    public string Descripcion { get; set; }
}
