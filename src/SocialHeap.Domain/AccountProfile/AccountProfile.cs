using System;
using Volo.Abp.Domain.Entities;

namespace SocialHeap.AccountProfile;

public class AccountProfile : AggregateRoot<Guid>
{
    public Guid UserId { get; set; }
    public string AvatarUrl { get; set; }
}