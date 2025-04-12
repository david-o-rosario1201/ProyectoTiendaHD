using System.ComponentModel.DataAnnotations;

namespace TiendaHDProject.Modelos;

public class PropuestaValor
{
	[Key]
	public int PropuestaValorId { get; set; }
    public string Descripcion { get; set; }
}
