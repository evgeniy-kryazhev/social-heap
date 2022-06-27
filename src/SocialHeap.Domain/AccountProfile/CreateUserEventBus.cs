using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.Users;

namespace SocialHeap.Profile;

public class CreateUserEventBus : IDistributedEventHandler<EntityCreatedEto<UserEto>>,
    ITransientDependency
{
    public Task HandleEventAsync(EntityCreatedEto<UserEto> eventData)
    {
        return Task.CompletedTask;
    }
}