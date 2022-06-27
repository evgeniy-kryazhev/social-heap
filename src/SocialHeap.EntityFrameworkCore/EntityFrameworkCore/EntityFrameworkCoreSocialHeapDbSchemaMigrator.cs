using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SocialHeap.Data;
using Volo.Abp.DependencyInjection;

namespace SocialHeap.EntityFrameworkCore;

public class EntityFrameworkCoreSocialHeapDbSchemaMigrator
    : ISocialHeapDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSocialHeapDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SocialHeapDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SocialHeapDbContext>()
            .Database
            .MigrateAsync();
    }
}
