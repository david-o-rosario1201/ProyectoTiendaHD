namespace ProyectoTiendaHD.Modelos;

public class DetalleClienteGusto
{
    public int DetalleId { get; set; }
    public int ClienteId { get; set; }
    public int GustoId { get; set; }

    public Cliente Cliente { get; set; }
    public Gusto Gusto { get; set; }
}