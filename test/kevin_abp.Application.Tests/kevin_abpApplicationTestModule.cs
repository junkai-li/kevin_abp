using Volo.Abp.Modularity;

namespace kevin_abp;

[DependsOn(
    typeof(kevin_abpApplicationModule),
    typeof(kevin_abpDomainTestModule)
    )]
public class kevin_abpApplicationTestModule : AbpModule
{

}
