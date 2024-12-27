using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using HyperX.Localization;

namespace HyperX.HttpApi.Hosting;

[Dependency(ReplaceServices = true)]
public class HyperXBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<HyperXResource> _localizer;

    public HyperXBrandingProvider(IStringLocalizer<HyperXResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
