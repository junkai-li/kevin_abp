using Volo.Abp.Settings;

namespace kevin_abp.Settings;

public class kevin_abpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(kevin_abpSettings.MySetting1));
    }
}
