using StudentService.Data;
using StudentService.Interfaces;

namespace StudentService.Utilities
{
    public class StateLGAValidator : IStateLGAValidator
    {
        private readonly ApplicationDbContext _context;

        public StateLGAValidator(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Validate(string state, string lga)
        {
            return _context.StateLGAs.Any(s => s.State == state && s.LGA == lga);
        }
    }
}
