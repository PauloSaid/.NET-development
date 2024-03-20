using AppSemTemplate.Configuration;
using CRUD.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder
    .AddGlobalizationConfig()
    .AddMvcConfiguration()
    .AddIdentityConfiguration();

var app = builder.Build();

app.UseMvcConfiguration();

app.Run();


