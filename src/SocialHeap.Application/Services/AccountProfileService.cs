using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using SocialHeap.AccountProfile;
using SocialHeap.Profile;
using Volo.Abp.Users;

namespace SocialHeap.Services;

[Authorize]
public class AccountProfileService : SocialHeapAppService, IAccountProfileService
{
    private readonly IAccountProfileRepository _accountProfileRepository;
    private readonly ICurrentUser _currentUser;

    public AccountProfileService(IAccountProfileRepository accountProfileRepository, ICurrentUser currentUser)
    {
        _accountProfileRepository = accountProfileRepository;
        _currentUser = currentUser;
    }

    public async Task<AccountProfileDto> GetProfile()
    {
        var accountProfile = await _accountProfileRepository
            .GetProfileByUserAsync(_currentUser.GetId());
        
        return new AccountProfileDto()
        {
            AvatarUrl = accountProfile.AvatarUrl,
            Email = _currentUser.Email
        };
    }
}