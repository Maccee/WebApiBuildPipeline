using Microsoft.AspNetCore.Mvc;
using Azure_02_Web_API_Build_Pipeline.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Azure_02_Web_API_Build_Pipeline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaavontunnitController : ControllerBase
    {
        private readonly PaavontunnitsqldatabaseContext _context;

        public PaavontunnitController(PaavontunnitsqldatabaseContext context)
        {
            _context = context;
        }

        // GET: /Paavontunnit
        [HttpGet]
        public async Task<IActionResult> GetPaavontunnits()
        {
            var paavontunnits = await _context.Paavontunnits.ToListAsync();
            return Ok(paavontunnits);
        }

        // GET: /Paavontunnit/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPaavontunnit(int id)
        {
            var paavontunnit = await _context.Paavontunnits
                .FirstOrDefaultAsync(e => e.Id == id);

            if (paavontunnit == null)
            {
                return NotFound();
            }

            return Ok(paavontunnit);
        }
    }
}
