using System.Threading.Tasks;

namespace kevin_abp.Data;

public interface Ikevin_abpDbSchemaMigrator
{
    Task MigrateAsync();
}
