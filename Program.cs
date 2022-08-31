using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Connect to PostgreSQL Database
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataDb>(options =>
    options.UseNpgsql(connectionString));

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapPost("/data/", async (DataRequestDto dataRequest, DataDb db) =>
{
    foreach (var item in dataRequest.data)
    {
        db.Logs.Add(item);
    }
    await db.SaveChangesAsync();

    return Results.Ok(dataRequest);
});

app.MapGet("/data/{id:int}", async (int id, DataDb db) =>
{
    return await db.Logs.FindAsync(id)
            is Data n
                ? Results.Ok(n)
                : Results.NotFound();
});

app.MapGet("/data", async (DataDb db) => await db.Logs.ToListAsync());

app.Run();

// Models and DTOs
record Data(int id, string timeStamp, string station, decimal temperature, decimal dewPoint,
byte humidity, string windDirection, decimal windSpeed, decimal gust, decimal pressure,
decimal precipitationRate, decimal precipitationAcc, decimal uv, decimal solarIrradiation);

record DataRequestDto(List<Data> data);

// Database context
class DataDb : DbContext
{
    public DataDb(DbContextOptions<DataDb> options) : base(options)
    {

    }
    public DbSet<Data> Logs => Set<Data>();
}