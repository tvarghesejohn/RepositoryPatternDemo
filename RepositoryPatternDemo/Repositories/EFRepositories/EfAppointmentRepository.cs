using RepositoryPatternDemo.DL;

namespace RepositoryPatternDemo.Repositories.EFRepositories
{
    public class EfAppointmentRepository : EfBaseRepository<Appointment>
    {
        private readonly HOSPITALDBContext _context;

        public EfAppointmentRepository(HOSPITALDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
