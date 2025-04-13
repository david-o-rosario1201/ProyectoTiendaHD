using Microsoft.EntityFrameworkCore;
using ProyectoTiendaHD.DAL;
using ProyectoTiendaHD.Modelos;
using System.Linq.Expressions;

namespace ProyectoTiendaHD.Services;

public class ModeloNegocioService
{
	private readonly Contexto _contexto;

	public ModeloNegocioService(Contexto contexto)
	{
		_contexto = contexto;
	}

	public async Task<bool> Crear(ModeloNegocio modelo)
	{
		if (!await Existe(modelo.ModeloNegocioId))
			return await Insertar(modelo);
		else
			return await Modificar(modelo);
	}

	public async Task<bool> Existe(int id)
	{
		return await _contexto.ModeloNegocio
			.AnyAsync(c => c.ModeloNegocioId == id);
	}

	public async Task<bool> Insertar(ModeloNegocio modelo)
	{
		_contexto.ModeloNegocio.Add(modelo);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(ModeloNegocio modelo)
	{
		_contexto.Update(modelo);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(modelo).State = EntityState.Detached;
		return modifico;
	}

	public async Task<bool> Eliminar(int id)
	{
		var cantidad = await _contexto.ModeloNegocio
			.Where(c => c.ModeloNegocioId == id)
			.ExecuteDeleteAsync();

		return cantidad > 0;
	}

	public async Task<ModeloNegocio?> Buscar(int id)
	{
		return await _contexto.ModeloNegocio
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.ModeloNegocioId == id);
	}

	public async Task<List<ModeloNegocio>> Listar(Expression<Func<ModeloNegocio, bool>> criterio)
	{
		return await _contexto.ModeloNegocio
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}
