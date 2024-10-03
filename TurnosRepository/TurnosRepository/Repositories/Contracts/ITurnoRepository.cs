using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnosRepository.Models.Entities;

namespace TurnosRepository.Repositories.Contracts
{
    public interface ITurnoRepository
    {

        void nuevoTurno(TTurno Turno);
        List<TTurno> ConsultarTurnos();
        List<TTurno> consultarTurnoPorFecha(String fecha, string hora);
        List<TTurno> consultarTurnoPorCliente(String cliente); 
        void editarTurno(TTurno turno);
        void CancelarTurno(int id, string motivo);



    }
}
