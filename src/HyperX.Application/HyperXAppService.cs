using HyperX.Localization;
using Volo.Abp.Application.Services;

namespace HyperX;

/* Inherit your application services from this class.
 */
public abstract class HyperXAppService : ApplicationService
{
    protected HyperXAppService()
    {
        LocalizationResource = typeof(HyperXResource);
    }
}
