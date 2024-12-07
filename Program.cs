using Microsoft.EntityFrameworkCore;
using question_api;
using question_api.Interfaces;
using question_api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure Entity Framework with SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=app.db"));


//Injeção de dependencia

builder.Services.AddScoped(typeof(IQuestionServices), typeof(QuestionServices));
builder.Services.AddTransient(typeof(AppDbContext));


var app = builder.Build();

// Ensure the database is created automatically
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    dbContext.Database.EnsureCreated(); // Ensures SQLite database exists
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware pipeline configuration
app.UseRouting();
app.UseAuthorization();

// Map controllers
app.MapControllers();

app.Run();