using kevin_abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace kevin_abp;

[DependsOn(
    typeof(kevin_abpEntityFrameworkCoreTestModule)
    )]
public class kevin_abpDomainTestModule : AbpModule
{

}
