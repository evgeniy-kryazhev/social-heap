using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SocialHeap.Data;

/* This is used if database provider does't define
 * ISocialHeapDbSchemaMigrator implementation.
 */
public class NullSocialHeapDbSchemaMigrator : ISocialHeapDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
