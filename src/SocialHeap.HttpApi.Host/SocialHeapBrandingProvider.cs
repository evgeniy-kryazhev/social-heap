using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SocialHeap;

[Dependency(ReplaceServices = true)]
public class SocialHeapBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SocialHeap";
}
