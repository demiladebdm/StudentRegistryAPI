using StudentService.Models;

namespace StudentService.Interfaces
{
    public interface IStateLGAService
    {
        Task<IEnumerable<StateLGA>> GetAllStateLGAsAsync();
    }
}
