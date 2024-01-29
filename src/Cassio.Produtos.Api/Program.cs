using Cassio.Produtos.Api;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();
