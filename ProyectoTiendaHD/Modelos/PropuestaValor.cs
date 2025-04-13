using System.ComponentModel.DataAnnotations;

namespace ProyectoTiendaHD.Modelos;

public class PropuestaValor
{
	[Key]
	public int PropuestaValorId { get; set; }
    public string Descripcion { get; set; }
}
