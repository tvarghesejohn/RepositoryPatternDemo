using RepositoryPatternDemo.DL;

namespace RepositoryPatternDemo.Repositories.EFRepositories
{
    public class EfHospitalRepository : EfBaseRepository<Hospital>
    {
        private readonly HOSPITALDBContext _context;

        public EfHospitalRepository(HOSPITALDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
