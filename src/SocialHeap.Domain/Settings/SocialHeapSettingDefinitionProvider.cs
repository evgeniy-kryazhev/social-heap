using Volo.Abp.Settings;

namespace SocialHeap.Settings;

public class SocialHeapSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SocialHeapSettings.MySetting1));
    }
}
