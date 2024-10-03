using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnosRepository.Models.Entities;
using TurnosRepository.Repositories.Contracts;

namespace TurnosRepository.Repositories.Implementations
{
    public class TurnoRepository : ITurnoRepository
    {

        private readonly turnosDbContext _turnosDbContext;

        public TurnoRepository(turnosDbContext turnosDbContext)
        {
            _turnosDbContext = turnosDbContext;
        }



        public void CancelarTurno(int id, string motivo)
        {
            var turnoCancelado = _turnosDbContext.TTurnos.Find(id);
            if (turnoCancelado != null)
            {
                turnoCancelado.FechaCancelacion = DateTime.Now.Date.ToString("mm/dd/yyyy");
                turnoCancelado.MotivoCancelacion = motivo;

                
                _turnosDbContext.SaveChanges();
            }
        }

        public List<TTurno> ConsultarTurnos()
        {
           return _turnosDbContext.TTurnos.ToList();
        }

        public List<TTurno> consultarTurnoPorCliente(string cliente)
        {
            return _turnosDbContext.TTurnos.Where(x => x.Cliente == cliente).ToList();
        }

        public List<TTurno> consultarTurnoPorFecha(string fecha, string hora)
        {
            return _turnosDbContext.TTurnos.Where(x => x.Fecha == fecha && x.Hora == hora).ToList();
        }

        public void editarTurno(TTurno turno)
        {
            if(turno != null)
            {
                _turnosDbContext.TTurnos.Update(turno);
                _turnosDbContext.SaveChanges();
            }
        }

        public void nuevoTurno(TTurno Turno)
        {
            _turnosDbContext.TTurnos.Add(Turno);
            _turnosDbContext.SaveChanges();
        }
    }
}
