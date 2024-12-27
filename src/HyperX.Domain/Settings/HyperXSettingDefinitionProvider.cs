using Volo.Abp.Settings;

namespace HyperX.Settings;

public class HyperXSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HyperXSettings.MySetting1));
    }
}
