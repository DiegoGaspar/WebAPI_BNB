using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        // POST: api/Agendamentos
        [HttpPost]
        public void PostTipoDeCarga(Agendamento agendamento)
        {
            agendamento.HorarioInicial = agendamento.Data.ToString("HH:mm:ss");
            agendamento.HorarioDeTermino = agendamento.Data.AddHours(1).ToString("HH:mm:ss");
            var a = _context.HorarioValido(agendamento.Data);

            if (a)
            {
                System.Console.WriteLine("Teste");
            }
        }

    }
}
