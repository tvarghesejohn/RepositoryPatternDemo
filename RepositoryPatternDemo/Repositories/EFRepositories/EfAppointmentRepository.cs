using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repositories.EFRepositories
{
    public class EfAppointmentRepository : EfBaseRepository<Appointment>
    {
        private readonly ApplicationDbContext _context;

        public EfAppointmentRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
