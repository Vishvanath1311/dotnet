using System.Diagnostics;
using BOL;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/Hello", () => "Hello World!");
app.MapGet("/api/Catlog",()=>"Product CAtlog");
app.MapGet("/json",()=>new {Name="Shubham",Desig="DEveloper"});
app.MapGet("/Activities",()=>{
    List<Activity> items=ProjectManager.GetAll();
    return items;
});

app.MapPost("/api/pmp/activities", async (Activity Activity) =>
{
    return Results.Created($"/pmp/{Activity.Id}", Activity);
});

app.Run();
