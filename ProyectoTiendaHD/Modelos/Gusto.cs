using System.ComponentModel.DataAnnotations;

namespace ProyectoTiendaHD.Modelos;

public class Gusto
{
	[Key]
	public int GustoId { get; set; }
	public int ClienteId { get; set; }
    public string Descripcion { get; set; }
}
