using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using kevin_abp.Data;
using Volo.Abp.DependencyInjection;

namespace kevin_abp.EntityFrameworkCore;

public class EntityFrameworkCorekevin_abpDbSchemaMigrator
    : Ikevin_abpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorekevin_abpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the kevin_abpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<kevin_abpDbContext>()
            .Database
            .MigrateAsync();
    }
}
