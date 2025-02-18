var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//enable serving static file
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");

app.Run();
// dont forget to add index.html at the end of url that is loaded