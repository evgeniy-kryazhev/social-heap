using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace SocialHeap.AccountProfile;

public interface IAccountProfileService : IApplicationService
{
    Task<AccountProfileDto> GetProfile();
}