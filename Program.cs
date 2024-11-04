using Exo.WebApi.Contexts;
using Exo.WebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configuração dos serviços
builder.Services.AddDbContext<ExoContext>(); // Configura o contexto do banco de dados
builder.Services.AddScoped<ExoContext, ExoContext>();

// Adicionando os repositórios como serviços
builder.Services.AddTransient<ProjetoRepository, ProjetoRepository>();
builder.Services.AddTransient<UsuarioRepository, UsuarioRepository>();

// Adicionando suporte a controladores
builder.Services.AddControllers();

// Construção da aplicação
var app = builder.Build();

// Configuração do pipeline de middleware
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Mapeia os controladores
});

// Execução da aplicação
app.Run();
