using Microsoft.AspNetCore.Mvc;
using Backend.Data;
using Backend.Models;
using Backend.Services;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VinoController : ControllerBase
    {
        private readonly IVinoServices _vinoServices;

        public VinoController(IVinoServices vinoServices)
        {
            _vinoServices = vinoServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vino>>> GetVinos()
        {
            var vinos = await _vinoServices.GetVinos();
            return Ok(vinos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vino>> GetVino(int id)
        {
            var vino = await _vinoServices.GetVino(id);
            if (vino == null)
            {
                return NotFound();
            }
            return Ok(vino);
        }
        [HttpPost]
        public async Task<ActionResult<Vino>> AddVino(Vino vino)
        {
            var newVino = await _vinoServices.AddVino(vino);
            return CreatedAtAction(nameof(GetVino), new { id = newVino.Id }, newVino);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVino(int id)
        {
            var result = await _vinoServices.DeleteVino(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
        
    }
}