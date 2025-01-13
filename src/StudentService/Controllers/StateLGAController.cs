using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Interfaces;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateLGAController : ControllerBase
    {
        private readonly IStateLGAService _stateLGAService;

        public StateLGAController(IStateLGAService stateLGAService)
        {
            _stateLGAService = stateLGAService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStateLGAs()
        {
            var stateLGAs = await _stateLGAService.GetAllStateLGAsAsync();
            return Ok(stateLGAs);
        }
    }
}