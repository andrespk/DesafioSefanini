using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace service.Customers
{
    public interface ICustomerService
    {
        Task<IEnumerable<UserSys>> GetAllAsync(string userId);

        Task<IEnumerable<Customer>> GetByFilterAsync(Expression<Func<Customer, bool>> predicate, string userId);
    }
}