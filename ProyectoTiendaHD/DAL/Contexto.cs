﻿using Microsoft.EntityFrameworkCore;

namespace ProyectoTiendaHD.DAL;

public class Contexto : DbContext
{
	public Contexto(DbContextOptions<Contexto> options) : base(options)
	{

	}
}
