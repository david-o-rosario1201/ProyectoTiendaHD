using System.ComponentModel.DataAnnotations;

namespace ProyectoTiendaHD.Modelos;

public class IngresoPrecio
{
	[Key]
	public int IngresoPrecioId { get; set; }
    public string Descripcion { get; set; }
}
