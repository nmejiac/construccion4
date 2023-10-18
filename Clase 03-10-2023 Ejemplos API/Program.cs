var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// api/v1

app.MapGet("/api/v1/ping", () => "Pong!!");
app.MapGet("/api/v1/usuario", () => "Hola {}");

// parametros en una url
app.MapGet("/api/v1/usuario/{nombre}", (string nombre) => $"Hola {nombre}");

// validar que desde la ruta si se envie el tipo de dato que es
app.MapGet("/api/v1/usuario/cedula/{cedula:int}", (int cedula) => $"Hola la cedula es: {cedula}");

//ejemplo uuid
//app.MapGet("/api/v1/usuario/uuid/{uuid}", (string uuid) => $"Hola la cedula es: {uuid}");


app.MapGet("/api/v1/usuario/uuid/{uuid:guid}", (Guid uuid) => $"Hola la cedula es: {uuid}");

app.MapGet("/api/v1/usuario/{nombre}/{cedula:int}/{uuid:guid}", (Guid uuid, string nombre, int cedula) => $"Hola {nombre}, su uuid es: {uuid} y su cedula es: {cedula}");

//Ejemplo parametros
app.MapGet("/api/v1/usuario/f/filter", (Guid uuid, string nombre, int cedula) => $"Hola {nombre}, su uuid es: {uuid} y su cedula es: {cedula}");






app.Run();
