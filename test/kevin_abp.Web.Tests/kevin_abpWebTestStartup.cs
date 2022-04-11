using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace kevin_abp;

public class kevin_abpWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<kevin_abpWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
