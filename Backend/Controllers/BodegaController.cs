using Microsoft.AspNetCore.Mvc;
using Backend.Data;
using Backend.Models;
using Backend.Services;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BodegaController : ControllerBase
    {
        private readonly IBodegaServices _bodegaServices;
        public BodegaController(IBodegaServices bodegaServices)
        {
            _bodegaServices = bodegaServices;
        }

        [HttpGet]
        public async Task<ActionResult<List<Bodega>>> GetBodegas()
        {
            var bodegas = await _bodegaServices.GetBodegas();
            return Ok(bodegas);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Bodega>> GetBodega(int id)
        {
            var bodega = await _bodegaServices.GetBodega(id);
            if (bodega == null)
            {
                return NotFound();
            }
            return Ok(bodega);
        }
        [HttpPost]
        public async Task<ActionResult<Bodega>> AddBodega(Bodega bodega)
        {
            var newBodega = await _bodegaServices.AddBodega(bodega);
            return CreatedAtAction(nameof(GetBodega), new { id = newBodega.Id }, newBodega);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBodega(int id)
        {
            var result = await _bodegaServices.DeleteBodega(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }

    }
}
