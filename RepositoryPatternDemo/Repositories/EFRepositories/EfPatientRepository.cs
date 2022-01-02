using RepositoryPatternDemo.DL;
using RepositoryPatternDemo.Repositories.EFRepositories;

namespace RepositoryPatternDemo.EFRepositories
{
    public class EFPatientRepository : EfBaseRepository<Patient>
    {
        private readonly HOSPITALDBContext _context;

        public EFPatientRepository(HOSPITALDBContext context) : base(context)
        {
            _context = context;
        }      
    }
}
