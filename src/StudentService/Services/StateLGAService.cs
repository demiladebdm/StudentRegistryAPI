using Microsoft.EntityFrameworkCore;
using StudentService.Data;
using StudentService.Interfaces;
using StudentService.Models;

namespace StudentService.Services
{
    public class StateLGAService : IStateLGAService
    {
        private readonly ApplicationDbContext _context;

        public StateLGAService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<StateLGA>> GetAllStateLGAsAsync()
        {
            return await _context.StateLGAs.ToListAsync();
        }
    }
}
