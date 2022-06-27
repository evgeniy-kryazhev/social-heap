using SocialHeap.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SocialHeap.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SocialHeapEntityFrameworkCoreModule),
    typeof(SocialHeapApplicationContractsModule)
    )]
public class SocialHeapDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
