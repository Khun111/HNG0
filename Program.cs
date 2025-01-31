var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


app.MapGet("/", () =>
{
    return Results.Json(new { email = "amure387@gmail.com", current_datetime = DateTime.Now.ToString("yyyy-MM-ddTHH:mmZ"), github_url = "https://github.com/Khun111/HNG0" });
})
.WithName("Home");

app.Run();

{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
