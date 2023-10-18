using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/api/v1/estudiante/{name}", (string name) => $"Nombre: {name}");
app.MapPost("/api/v1/estudiante", (JsonElement estudiante) => {
    string nombre = estudiante.GetProperty("name").GetString();
    return Results.Ok($"el nombre del estudiante es: {nombre}");
});

app.MapPost("/api/v1/estudianteDTO", (EstudianteDTO estudiante) => {
    //string nombre = estudiante.GetProperty("name").GetString();
    return Results.Ok(estudiante);
});

app.MapPost("/", () => "Hello Post!");

app.Run();
public class EstudianteDTO{
    public string name {get;set;}
    public string edad {get;set;}
};


public class AsignaturaDTO{
    public string name {get;set;}
    public string edad {get;set;}
};




