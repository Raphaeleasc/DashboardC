using System.Dynamic;
using System.IO.Pipelines;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EdataDb>(opt => opt.UseInMemoryDatabase("EdataList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/Degree/{id:int}",(int id) => id);

app.MapGet("/edatas", async (EdataDb db) =>
    await db.Edatas.ToListAsync());


app.MapPost("/edatas", async(Edata edata, EdataDb db) => {
    db.Edatas.Add(edata);
    await db.SaveChangesAsync();

    return Results.Created($"/edatas/{edata.Id}", edata);
});

app.Run();


