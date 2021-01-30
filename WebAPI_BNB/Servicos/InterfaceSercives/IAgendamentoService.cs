/************************
 *Criado por Diego Gaspar
 ************************/

using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI_BNB.Models;

namespace WebAPI_BNB.Servicos.InterfaceServices
{
    public interface IAgendamentoService
    {
        Task<IEnumerable<Agendamento>> ListAsync();
    }
}
