using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace kevin_abp.Data;

/* This is used if database provider does't define
 * Ikevin_abpDbSchemaMigrator implementation.
 */
public class Nullkevin_abpDbSchemaMigrator : Ikevin_abpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
