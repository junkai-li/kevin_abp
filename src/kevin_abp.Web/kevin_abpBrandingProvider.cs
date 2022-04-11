using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace kevin_abp.Web;

[Dependency(ReplaceServices = true)]
public class kevin_abpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "kevin_abp";
}
