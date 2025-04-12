using System.ComponentModel.DataAnnotations;

namespace ProyectoTiendaHD.Modelos;

public class CanalDistribucion
{
	[Key]
	public int CanalDistribucionId { get; set; }
    public string Descripcion { get; set; }
}
