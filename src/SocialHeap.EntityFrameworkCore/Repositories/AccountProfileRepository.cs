using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialHeap.EntityFrameworkCore;
using SocialHeap.Profile;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace SocialHeap.Repositories;

public class AccountProfileRepository : EfCoreRepository<SocialHeapDbContext, AccountProfile.AccountProfile, Guid>,
    IAccountProfileRepository
{
    public AccountProfileRepository(IDbContextProvider<SocialHeapDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task<AccountProfile.AccountProfile> GetProfileByUserAsync(Guid userId)
    {
        var dbSet = await GetDbSetAsync();
        var accountProfile = await dbSet
            .FirstOrDefaultAsync(a => a.UserId == userId);

        if (accountProfile is null)
        {
            accountProfile = await InsertAsync(new AccountProfile.AccountProfile()
            {
                UserId = userId
            });
        }
        
        return accountProfile;
    }
}