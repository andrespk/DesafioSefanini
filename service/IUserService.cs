using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace backend.Services
{
    public interface IUserService
    {
        Task<bool> Login(string uid, string password);

        Task<IEnumerable<UserSys>> GetAllAsync();

        Task<IEnumerable<UserSys>> GetByFilterAsync(Expression<Func<UserSys, bool>> predicate);

        Task<IEnumerable<UserRole>> GetRolesAsync(int userId);
    }
}