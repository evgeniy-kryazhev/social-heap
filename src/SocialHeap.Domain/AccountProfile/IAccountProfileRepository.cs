using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace SocialHeap.Profile;

public interface IAccountProfileRepository : IRepository<AccountProfile.AccountProfile, Guid>
{
    Task<AccountProfile.AccountProfile> GetProfileByUserAsync(Guid userId);
}