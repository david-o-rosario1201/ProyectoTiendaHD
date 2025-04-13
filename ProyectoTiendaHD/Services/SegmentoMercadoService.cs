using Microsoft.EntityFrameworkCore;
using ProyectoTiendaHD.DAL;
using ProyectoTiendaHD.Modelos;
using System.Linq.Expressions;

namespace ProyectoTiendaHD.Services;

public class SegmentoMercadoService
{
	private readonly Contexto _contexto;

	public SegmentoMercadoService(Contexto contexto)
	{
		_contexto = contexto;
	}

	public async Task<int> Crear(SegmentoMercado segmento)
	{
		if (!await Existe(segmento.SegmentoMercadoId))
		{
			_contexto.SegmentoMercado.Add(segmento);
			await _contexto.SaveChangesAsync();
			return segmento.SegmentoMercadoId;
		}
		else
		{
			_contexto.Update(segmento);
			await _contexto.SaveChangesAsync();
			_contexto.Entry(segmento).State = EntityState.Detached;
			return segmento.SegmentoMercadoId;
		}
	}

	public async Task<bool> Existe(int id)
	{
		return await _contexto.SegmentoMercado
			.AnyAsync(c => c.SegmentoMercadoId == id);
	}

	public async Task<bool> Insertar(SegmentoMercado segmento)
	{
		_contexto.SegmentoMercado.Add(segmento);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(SegmentoMercado segmento)
	{
		_contexto.Update(segmento);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(segmento).State = EntityState.Detached;
		return modifico;
	}

	public async Task<bool> Eliminar(int id)
	{
		var cantidad = await _contexto.SegmentoMercado
			.Where(c => c.SegmentoMercadoId == id)
			.ExecuteDeleteAsync();

		return cantidad > 0;
	}

	public async Task<SegmentoMercado?> Buscar(int id)
	{
		return await _contexto.SegmentoMercado
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.SegmentoMercadoId == id);
	}

	public async Task<List<SegmentoMercado>> Listar(Expression<Func<SegmentoMercado, bool>> criterio)
	{
		return await _contexto.SegmentoMercado
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}
