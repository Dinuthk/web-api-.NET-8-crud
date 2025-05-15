var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add service to the container
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

//routing

// about shirt

//app.MapGet("/shirts", () =>
//{
//    return "reading all the shirt";
//});
//app.MapGet("/shirts/{id}", (int id) =>
//{
//    return $"reading shirt with id: {id}";
//});
//app.MapPost("/shirts", () =>
//{
//    return "shirt added";
//});
//app.MapPut("/shirts/{id}", (int id)=>{
//    return $"updating shirt with id: {id}";
//});
//app.MapDelete("/shirts/{id}", (int id) => {
//    return $"remove shirt with id: {id}";
//});

app.MapControllers();

app.Run();
