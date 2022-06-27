using Volo.Abp.Modularity;

namespace SocialHeap;

[DependsOn(
    typeof(SocialHeapApplicationModule),
    typeof(SocialHeapDomainTestModule)
    )]
public class SocialHeapApplicationTestModule : AbpModule
{

}
