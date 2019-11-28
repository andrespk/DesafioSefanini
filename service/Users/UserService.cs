using domain.Entities;
using infra.CrossCutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace service.Users
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserSys>> GetAllAsync()
        {
            return await Task.FromResult(_context.SystemUsers.ToList());
        }

        public async Task<IEnumerable<UserSys>> GetByFilterAsync(Expression<Func<UserSys, bool>> predicate)
        {
            return await Task.FromResult(_context.SystemUsers.Where(predicate));
        }

        public async Task<IEnumerable<UserRole>> GetRolesAsync(int userId)
        {
            var user = await Task.FromResult(_context.SystemUsers.FirstOrDefault(u => u.Id == userId));
            return await Task.FromResult(_context.SystemRoles.Where(r => r.Id == user.UserRoleId));
        }

        public Task<bool> Login(string uid, string password)
        {
            throw new NotImplementedException();
        }
    }
}