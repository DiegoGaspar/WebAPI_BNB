/************************
 *Criado por Diego Gaspar
 ************************/

using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI_BNB.Models;
using WebAPI_BNB.Repositories.Interfaces;
using WebAPI_BNB.Servicos.InterfaceServices;

namespace WebAPI_BNB.Servicos
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IAgendamentoRepository _agendamentoRepository;
        public AgendamentoService(IAgendamentoRepository categoriaRepository)
        {
            _agendamentoRepository = categoriaRepository;
        }

        public async Task<IEnumerable<Agendamento>> ListAsync()
        {
            return await _agendamentoRepository.ListAsync();
        }
    }
}
