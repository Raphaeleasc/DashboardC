using System.Dynamic;
using System.IO.Pipelines;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/Degree/{id:int}",(int id) => id);
//app.MapGet("/Degree/{id:int}",(int id,Degree degree) => {degree = new Degree();degree.Show(id);});
app.Run();


