using SocialHeap.Localization;
using Volo.Abp.AspNetCore.Components;

namespace SocialHeap.Blazor;

public abstract class SocialHeapComponentBase : AbpComponentBase
{
    protected SocialHeapComponentBase()
    {
        LocalizationResource = typeof(SocialHeapResource);
    }
}
