using HyperX.HttpApi.Hosting;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseAutofac();  //Add this line
await builder.AddApplicationAsync<HyperXHttpApiHostingModule>();
var app = builder.Build();
await app.InitializeApplicationAsync();
await app.RunAsync();
