using Microsoft.EntityFrameworkCore;
using ProyectoTiendaHD.DAL;
using ProyectoTiendaHD.Modelos;
using System.Linq.Expressions;

namespace ProyectoTiendaHD.Services;

public class PropuestaValorService
{
	private readonly Contexto _contexto;

	public PropuestaValorService(Contexto contexto)
	{
		_contexto = contexto;
	}

	public async Task<int> Crear(PropuestaValor propuesta)
	{
		if (!await Existe(propuesta.PropuestaValorId))
		{
			_contexto.PropuestaValor.Add(propuesta);
			await _contexto.SaveChangesAsync();
			return propuesta.PropuestaValorId;
		}
		else
		{
			_contexto.Update(propuesta);
			await _contexto.SaveChangesAsync();
			_contexto.Entry(propuesta).State = EntityState.Detached;
			return propuesta.PropuestaValorId;
		}
	}

	public async Task<bool> Existe(int id)
	{
		return await _contexto.PropuestaValor
			.AnyAsync(c => c.PropuestaValorId == id);
	}

	public async Task<bool> Insertar(PropuestaValor propuesta)
	{
		_contexto.PropuestaValor.Add(propuesta);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(PropuestaValor propuesta)
	{
		_contexto.Update(propuesta);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(propuesta).State = EntityState.Detached;
		return modifico;
	}

	public async Task<bool> Eliminar(int id)
	{
		var cantidad = await _contexto.PropuestaValor
			.Where(c => c.PropuestaValorId == id)
			.ExecuteDeleteAsync();

		return cantidad > 0;
	}

	public async Task<PropuestaValor?> Buscar(int id)
	{
		return await _contexto.PropuestaValor
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.PropuestaValorId == id);
	}

	public async Task<List<PropuestaValor>> Listar(Expression<Func<PropuestaValor, bool>> criterio)
	{
		return await _contexto.PropuestaValor
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}
