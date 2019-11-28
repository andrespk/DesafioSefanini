using domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace infra.Data.IdentityStores
{
    public class UserSysStore
    {
        public Task<IdentityResult> CreateAsync(UserSys user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<UserSys> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UserSys> FindByNameAsync(string name, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UserSys> FindByEmailAsync(string email, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}