using SocialHeap.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SocialHeap.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SocialHeapController : AbpControllerBase
{
    protected SocialHeapController()
    {
        LocalizationResource = typeof(SocialHeapResource);
    }
}
