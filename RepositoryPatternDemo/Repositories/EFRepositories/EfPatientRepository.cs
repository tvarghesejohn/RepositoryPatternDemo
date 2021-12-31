using RepositoryPatternDemo.IRepositories;
using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Repositories.EFRepositories;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryPatternDemo.EFRepositories
{
    public class EFPatientRepository : EfBaseRepository<Patient>
    {
        private readonly ApplicationDbContext _context;

        public EFPatientRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }      
    }
}
