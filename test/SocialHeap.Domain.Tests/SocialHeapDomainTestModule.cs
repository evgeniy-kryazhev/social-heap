using SocialHeap.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SocialHeap;

[DependsOn(
    typeof(SocialHeapEntityFrameworkCoreTestModule)
    )]
public class SocialHeapDomainTestModule : AbpModule
{

}
