using FastEndpoints;

var builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints();
var app = builder.Build();
app.Urls.Add("http://localhost:8080"); // this one is needed ?
app.UseFastEndpoints();
app.Run();