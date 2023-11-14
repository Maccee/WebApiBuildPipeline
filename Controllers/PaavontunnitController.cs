using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Azure_02_Web_API_Build_Pipeline.Data;
using Azure_02_Web_API_Build_Pipeline.Models;

namespace Azure_02_Web_API_Build_Pipeline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaavontunnitController : ControllerBase
    {
        private readonly PaavontunnitContext _context;

        public PaavontunnitController(PaavontunnitContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paavontunnit>>> GetMessages()
        {
            return await _context.Paavontunnit.ToListAsync();
        }
    }
}
