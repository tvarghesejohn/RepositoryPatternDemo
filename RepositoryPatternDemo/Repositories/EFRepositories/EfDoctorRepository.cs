using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repositories.EFRepositories
{
    public class EfDoctorRepository : EfBaseRepository<Doctor>
    {
        private readonly ApplicationDbContext _context;

        public EfDoctorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
