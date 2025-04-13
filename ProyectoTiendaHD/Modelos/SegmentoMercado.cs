using System.ComponentModel.DataAnnotations;

namespace ProyectoTiendaHD.Modelos;

public class SegmentoMercado
{
	[Key]
	public int SegmentoMercadoId { get; set; }
    public string Descripcion { get; set; }
}
