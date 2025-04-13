using Microsoft.EntityFrameworkCore;
using ProyectoTiendaHD.DAL;
using ProyectoTiendaHD.Modelos;
using System.Linq.Expressions;

namespace ProyectoTiendaHD.Services;

public class UsuarioService
{
	private readonly Contexto _contexto;

	public UsuarioService(Contexto contexto)
	{
		_contexto = contexto;
	}

	public async Task<bool> Crear(Usuario usuario)
	{
		if (!await Existe(usuario.UsuarioId))
			return await Insertar(usuario);
		else
			return await Modificar(usuario);
	}

	public async Task<bool> Existe(int id)
	{
		return await _contexto.Usuario
			.AnyAsync(c => c.UsuarioId == id);
	}

	public async Task<bool> Insertar(Usuario usuario)
	{
		_contexto.Usuario.Add(usuario);
		return await _contexto.SaveChangesAsync() > 0;
	}

	public async Task<bool> Modificar(Usuario usuario)
	{
		_contexto.Update(usuario);
		var modifico = await _contexto.SaveChangesAsync() > 0;
		_contexto.Entry(usuario).State = EntityState.Detached;
		return modifico;
	}

	public async Task<bool> Eliminar(int id)
	{
		var cantidad = await _contexto.Usuario
			.Where(c => c.UsuarioId == id)
			.ExecuteDeleteAsync();

		return cantidad > 0;
	}

	public async Task<Usuario?> Buscar(int id)
	{
		return await _contexto.Usuario
			.AsNoTracking()
			.FirstOrDefaultAsync(c => c.UsuarioId == id);
	}

	public async Task<List<Usuario>> Listar(Expression<Func<Usuario, bool>> criterio)
	{
		return await _contexto.Usuario
			.AsNoTracking()
			.Where(criterio)
			.ToListAsync();
	}
}
