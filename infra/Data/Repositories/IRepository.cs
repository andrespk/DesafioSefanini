using Microsoft.EntityFrameworkCore;

namespace infra.Data.Repositories
{
    public interface IRepository
    {
        DbContext GetDbContext();
    }
}