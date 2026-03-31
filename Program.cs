using ApiIdentityEndpoint.Data;
using Microsoft.Extensions.Options;
using System.Runtime.Intrinsics.Arm;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
    Options => options.UseSqlServer("server=localhost,1433,Database=balta;User") );

builder.Services.AddAuthentication();
builder.services.addAuthorization();

builder.Services.AddIdentityApiEndpoints<User>()
    .AddEntityFrameworkStores<AppDbContext>();

var app.WebApplication = builder.Build();

app.MapGet(SveMaskPattern"/", () => "Hello World!");
(
app.Run();