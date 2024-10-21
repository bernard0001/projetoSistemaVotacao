using Aula03.Models;
using Aula03.Persistence;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:5070") // URL do frontend Blazor
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EFCoreContext>(options => options.UseSqlite(
    builder.Configuration.GetConnectionString("DefaultConnection")
));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/api/candidatos", async (EFCoreContext context) =>
    {
        return await context.Candidatos.ToListAsync();
    }
);

app.MapPost("/api/candidatos", async (EFCoreContext context, CandidatoModeloModel candidato) =>
{
    context.Candidatos.Add(candidato);
    await context.SaveChangesAsync();
    return Results.Created($"/api/candidatos/{candidato.CandidatoID}", candidato);
});

app.UseCors();

app.Run();
