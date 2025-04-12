using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TiendaHDProject.Modelos;

namespace ProyectoTiendaHD.Modelos;

public class ActividadClave
{
    [Key]
    public int ActividadClaveId { get; set; }
    public string Descripcion { get; set; }

    [ForeignKey("ActividadClaveId")]
	public ICollection<RecursoClave> RecursoClaves { get; set; } = new List<RecursoClave>();
}
