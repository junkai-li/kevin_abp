using kevin_abp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace kevin_abp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class kevin_abpController : AbpControllerBase
{
    protected kevin_abpController()
    {
        LocalizationResource = typeof(kevin_abpResource);
    }
}
