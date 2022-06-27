using System;
using System.Collections.Generic;
using System.Text;
using SocialHeap.Localization;
using Volo.Abp.Application.Services;

namespace SocialHeap;

/* Inherit your application services from this class.
 */
public abstract class SocialHeapAppService : ApplicationService
{
    protected SocialHeapAppService()
    {
        LocalizationResource = typeof(SocialHeapResource);
    }
}
