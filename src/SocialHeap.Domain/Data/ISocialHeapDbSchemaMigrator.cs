using System.Threading.Tasks;

namespace SocialHeap.Data;

public interface ISocialHeapDbSchemaMigrator
{
    Task MigrateAsync();
}
