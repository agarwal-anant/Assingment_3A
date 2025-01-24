var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();  // This line is important to enable controller functionality
builder.Services.AddEndpointsApiExplorer();  // Swagger support
builder.Services.AddSwaggerGen();  // Swagger generator

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();  // Swagger UI to view and interact with the API
}

app.UseHttpsRedirection();

// Maps controllers to their routes (this is where your LibraryController will be included)
app.MapControllers();

app.Run();