using GerenciadorTarefasSimples.Services.Filters;
using GerenciadorTarefasSimples.Services.UseCases.Tasks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adicionado para fazer com que todas as rotas da api sejam minusculas
builder.Services.AddRouting(option => option.LowercaseUrls = true);

// Usando o AddSingleton podemos fazer a injecao de dependencia de deixar a mesma lista para todos os endpoint
builder.Services.AddSingleton<ITasksRepository, TasksRepository>();
builder.Services.AddMvc(option => option.Filters.Add(typeof(ExceptionFilter)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
