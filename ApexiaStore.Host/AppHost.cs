var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ApexiaStore_API_Identity>("identity-api");

builder.Build().Run();
