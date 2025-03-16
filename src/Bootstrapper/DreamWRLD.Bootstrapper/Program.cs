using DreamWRLD.Modules.Freelancer.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFreelancerModule(builder.Configuration);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();