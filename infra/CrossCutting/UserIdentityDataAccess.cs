using domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace infra.CrossCutting
{
    public class UserIdentityDataAccess
    {
        private List<UserSys> _users;

        public UserIdentityDataAccess()
        {
            _users = new List<UserSys>();
        }

        public bool CreateUser(UserSys user)
        {
            _users.Add(user);
            return true;
        }

        public UserSys GetUserById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public UserSys GetByEmail(string email)
        {
            return _users.FirstOrDefault(u => u.Email == email);
        }

        public UserSys GetUserByUsername(string username)
        {
            return _users.FirstOrDefault(u => u.UserName == username);
        }

        public UserSys GetUserByLogin(string login)
        {
            return _users.FirstOrDefault(u => u.Login == login);
        }

        public bool Update(UserSys user)
        {
            // Since get user gets the user from the same in-memory list, the user parameter is the
            // same as the object in the list, so nothing needs to be updated here.
            return true;
        }
    }
}