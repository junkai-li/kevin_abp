using System;
using System.Collections.Generic;
using System.Text;
using kevin_abp.Localization;
using Volo.Abp.Application.Services;

namespace kevin_abp;

/* Inherit your application services from this class.
 */
public abstract class kevin_abpAppService : ApplicationService
{
    protected kevin_abpAppService()
    {
        LocalizationResource = typeof(kevin_abpResource);
    }
}
