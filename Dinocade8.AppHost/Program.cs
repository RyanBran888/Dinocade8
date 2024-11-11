using Microsoft.Extensions.DependencyInjection;

var builder = DistributedApplication.CreateBuilder(args);

await builder.Build().RunAsync();
builder.Build().Run();
