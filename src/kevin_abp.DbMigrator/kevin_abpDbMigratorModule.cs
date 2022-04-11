using kevin_abp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace kevin_abp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(kevin_abpEntityFrameworkCoreModule),
    typeof(kevin_abpApplicationContractsModule)
    )]
public class kevin_abpDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
