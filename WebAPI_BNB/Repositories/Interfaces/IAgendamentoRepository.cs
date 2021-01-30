/************************
 *Criado por Diego Gaspar
 ************************/

using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI_BNB.Models;

namespace WebAPI_BNB.Repositories.Interfaces
{
    public interface IAgendamentoRepository
    {
        Task<IEnumerable<Agendamento>> ListAsync();
        Task AddAsync(Agendamento categoria);
        Task<Agendamento> FindByIdAsync(int id);
        void Update(Agendamento categoria);
        void Remove(Agendamento categoria);
    }
}
