var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.test5_ApiService>("apiservice");

builder.AddProject<Projects.test5_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
