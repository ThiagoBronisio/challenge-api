using ChallengeHackathon.Configs;
using ChallengeHackathon.Domain.Interfaces.Repositories;
using ChallengeHackathon.Domain.Interfaces.Services;
using ChallengeHackathon.Domain.Service;
using ChallengeHackathon.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

CORSConfig.Configure(builder.Services);

#region Injeções de dependência

builder.Services.AddTransient<IFinancaRepository, FinancaRepository>();
builder.Services.AddTransient<IFinancaDomainService, FinancaDomainService>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.UseCors(CORSConfig.PolicyName);

app.MapControllers();
app.Run();
