using Application.Interfaces.VehiculoInterfaces;
using Application.Models;
using Application.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cotizaciones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotizacionController : ControllerBase
    {
        private readonly IVehiculoService _service;

        public CotizacionController(IVehiculoService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> PostVehiculo(CrearVehiculoRequest request) 
        {
            try
            {
                var result = await _service.CotizarVehiculo(request);
                return new JsonResult(result);
            }
            catch (BadRequestException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
