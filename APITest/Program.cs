using System.Dynamic;
using System.IO.Pipelines;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/Degree/{id:int}",(int id) => id);
app.Run();


