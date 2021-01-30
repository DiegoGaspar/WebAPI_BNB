using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_BNB.Configuracao;
using WebAPI_BNB.Models;
using WebAPI_BNB.Servicos.InterfaceServices;

namespace WebAPI_BNB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentosController : ControllerBase
    {
        private readonly IAgendamentoService _context;

        public AgendamentosController(IAgendamentoService context)
        {
            _context = context;
        }

        // GET: api/Agendamentos
        [HttpGet]
        public async Task<IEnumerable<Agendamento>> GetAgendamentos()
        {
            var agendamento = await _context.ListAsync();
            return agendamento;
        }


    }
}
