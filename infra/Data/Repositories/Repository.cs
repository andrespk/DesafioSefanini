using infra.CrossCutting;
using Microsoft.EntityFrameworkCore;

namespace infra.Data.Repositories
{
    public class Repository : IRepository

    {
        private ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbContext GetDbContext()
        => _context;
    }
}