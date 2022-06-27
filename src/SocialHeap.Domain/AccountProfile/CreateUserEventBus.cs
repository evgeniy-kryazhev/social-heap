using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.Users;

namespace SocialHeap.Profile;

public class CreateUserEventBus : IDistributedEventHandler<EntityCreatedEto<UserEto>>,
    ITransientDependency
{
    private readonly IAccountProfileRepository _accountProfileRepository;

    public CreateUserEventBus(IAccountProfileRepository accountProfileRepository)
    {
        _accountProfileRepository = accountProfileRepository;
    }

    public async Task HandleEventAsync(EntityCreatedEto<UserEto> eventData)
    {
        var accountProfile = new AccountProfile.AccountProfile()
        {
            UserId = eventData.Entity.Id
        };
        await _accountProfileRepository.InsertAsync(accountProfile);
    }
}