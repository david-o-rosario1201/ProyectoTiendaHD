using Microsoft.EntityFrameworkCore;
using ProyectoTiendaHD.DAL;
using ProyectoTiendaHD.Modelos;
using System.Linq.Expressions;

namespace ProyectoTiendaHD.Services;

public class ClienteService
{
	private readonly Contexto _contexto;

	public ClienteService(Contexto contexto)
	{
		_contexto = contexto;
	}

	public async Task<int> Crear(Cliente cliente)
	{
		if (!await Existe(cliente.ClienteId))
		{
			_contexto.Cliente.Add(cliente);
			await _contexto.SaveChangesAsync();
			return cliente.ClienteId;
		}
		else
		{
			_contexto.Update(cliente);
			await _contexto.SaveChangesAsync();
			_contexto.Entry(cliente).State = EntityState.Detached;
			return cliente.ClienteId;
		}
	}

	public async Task<bool> Existe(int id)
	{
		return await _contexto.Cliente
			.AnyAsync(c => c.ClienteId == id);
	}

	public async Task<bool> Insertar(Cliente cliente)
	{
		_contexto.Cliente.Add(cliente);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(Cliente cliente)
	{
		_contexto.Update(cliente);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(cliente).State = EntityState.Detached;
		return modifico;
	}

	public async Task<bool> Eliminar(int id)
	{
		var cantidad = await _contexto.Cliente
			.Where(c => c.ClienteId == id)
			.ExecuteDeleteAsync();

		return cantidad > 0;
	}

	public async Task<Cliente?> Buscar(int id)
	{
		return await _contexto.Cliente
			.Include(d => d.DetallesGusto)
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.ClienteId == id);
	}

	public async Task<List<Cliente>> Listar(Expression<Func<Cliente, bool>> criterio)
	{
		return await _contexto.Cliente
			.Include(d => d.DetallesGusto)
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}
