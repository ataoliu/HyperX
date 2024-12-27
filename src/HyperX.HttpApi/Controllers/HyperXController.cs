using HyperX.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace HyperX.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HyperXController : AbpControllerBase
{
    protected HyperXController()
    {
        LocalizationResource = typeof(HyperXResource);
    }
}
