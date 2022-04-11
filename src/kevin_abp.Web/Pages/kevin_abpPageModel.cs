using kevin_abp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace kevin_abp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class kevin_abpPageModel : AbpPageModel
{
    protected kevin_abpPageModel()
    {
        LocalizationResourceType = typeof(kevin_abpResource);
    }
}
