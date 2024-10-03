using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnosRepository.Models.Entities;
using TurnosRepository.Repositories.Contracts;
using TurnosRepository.Service.Contracts;

namespace TurnosRepository.Service.Implementations
{
    public class TurnosService : ITurnosService
    {

        private readonly ITurnoRepository _turnosRepository;

        public TurnosService(ITurnoRepository turnosRepository)
        {
            _turnosRepository = turnosRepository;
            
        }


        public void CancelarTurno(int id, string motivo)
        {
            _turnosRepository.CancelarTurno(id,motivo);
        }

        public List<TTurno> consultarTurnos() 
        {
            return _turnosRepository.ConsultarTurnos();
        }

        public List<TTurno> consultarTurnoPorCliente(string cliente)
        {
            return _turnosRepository.consultarTurnoPorCliente(cliente);
        }

        public List<TTurno> consultarTurnoPorFecha(string fecha, string hora)
        {
           return _turnosRepository.consultarTurnoPorFecha(fecha, hora);
        }

        public void editarTurno(TTurno turno)
        {
            _turnosRepository.editarTurno(turno);
        }

        public void nuevoTurno(TTurno Turno)
        {
            _turnosRepository.nuevoTurno(Turno);
        }
    }
}
