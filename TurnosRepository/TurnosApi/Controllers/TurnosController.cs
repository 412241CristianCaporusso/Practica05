using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurnosRepository.Models.Entities;
using TurnosRepository.Repositories.Contracts;
using TurnosRepository.Service.Contracts;

namespace TurnosApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TurnosController : Controller
    {
        private readonly ITurnosService _turnosService;

        public TurnosController(ITurnosService turnosService) 
        {
            _turnosService = turnosService;
        }


        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_turnosService.consultarTurnos());
        }


        // GET: TurnosController
        [HttpGet("Getfecha")]
        public IActionResult GetPorFecha(string fecha, string hora)
        {
            return Ok(_turnosService.consultarTurnoPorFecha(fecha, hora));
        }

        [HttpGet("GetCliente")]
        public IActionResult GetPorCliente(string cliente)
        {
            return Ok(_turnosService.consultarTurnoPorCliente(cliente));
        }


        // POST: TurnosController/Create
        [HttpPost]
        public IActionResult Post([FromBody] TTurno turno)
        {
            try
            {
                if (IsValid(turno))
                {
                    _turnosService.nuevoTurno(turno);
                    return Ok("Turno Registrado");
                }
                else 
                {
                    return BadRequest("No se pudo guardar el turno, faltan algunos datos");
                }
            }
            catch
            {
                return StatusCode(500,"Ha courrido un error");
            }
        }

        private bool IsValid(TTurno turno)
        {
            return !string.IsNullOrEmpty(turno.Cliente) && !string.IsNullOrEmpty(turno.Fecha) && !string.IsNullOrEmpty(turno.Hora);
        }




        [HttpDelete("CancelarTurno")]
        
        public ActionResult Delete([FromQuery]int id, string motivo)
        {
            try
            {
                _turnosService.CancelarTurno(id, motivo);
                return Ok("Se registro la canceacion del turno , Turno Cancelado");
            }
            catch(Exception ) 
            {
                return StatusCode(500, "No se pudo cancelar el turno");
            }
        }

        [HttpPut("ActualizarTurno")]
        public IActionResult Update([FromQuery]TTurno turno)
        {
            try
            {
                _turnosService.editarTurno(turno);
                
                return Ok("Se actualizo correctamente el turno");
            }
            catch (Exception)
            {
                return NotFound("Ocurrio un error, intente nuevamente");
            }
        }


    }
}
