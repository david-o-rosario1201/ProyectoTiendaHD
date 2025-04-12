using System.ComponentModel.DataAnnotations;

namespace TiendaHDProject.Modelos;

public class SegmentoMercado
{
	[Key]
	public int SegmentoMercadoId { get; set; }
    public string Descripcion { get; set; }
}
