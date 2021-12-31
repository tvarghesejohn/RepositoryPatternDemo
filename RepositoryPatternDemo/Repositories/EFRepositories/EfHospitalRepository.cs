using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repositories.EFRepositories
{
    public class EfHospitalRepository : EfBaseRepository<Hospital>
    {
        private readonly ApplicationDbContext _context;

        public EfHospitalRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
