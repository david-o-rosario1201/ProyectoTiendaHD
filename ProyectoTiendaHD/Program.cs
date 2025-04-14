using Microsoft.EntityFrameworkCore;
using ProyectoTiendaHD.Components;
using ProyectoTiendaHD.DAL;
using ProyectoTiendaHD.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<Contexto>
		(o => o.UseSqlServer(builder.Configuration.GetConnectionString("ConStr")));

//Services
builder.Services.AddScoped<ModeloNegocioService>();
builder.Services.AddScoped<PropuestaValorService>();
builder.Services.AddScoped<SegmentoMercadoService>();
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<ClienteService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
