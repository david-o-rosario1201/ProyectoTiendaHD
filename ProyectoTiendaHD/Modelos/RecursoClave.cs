using System.ComponentModel.DataAnnotations;

namespace TiendaHDProject.Modelos;

public class RecursoClave
{
	[Key]
	public int RecursoClaveId { get; set; }

	public int ActividadClaveId { get; set; }
    public string Descripcion { get; set; }
}
