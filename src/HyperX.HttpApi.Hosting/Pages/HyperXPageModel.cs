using HyperX.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace HyperX.HttpApi.Hosting.Pages;

public abstract class HyperXPageModel : AbpPageModel
{
    protected HyperXPageModel()
    {
        LocalizationResourceType = typeof(HyperXResource);
    }
}
