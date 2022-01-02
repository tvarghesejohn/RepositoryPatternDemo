using RepositoryPatternDemo.DL;
using Doctor = RepositoryPatternDemo.DL.Doctor;

namespace RepositoryPatternDemo.Repositories.EFRepositories
{
    public class EfDoctorRepository : EfBaseRepository<Doctor>
    {
        private readonly HOSPITALDBContext _context;

        public EfDoctorRepository(HOSPITALDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
