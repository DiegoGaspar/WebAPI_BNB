using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI_BNB.Configuracao;
using WebAPI_BNB.Models;
using WebAPI_BNB.Servicos.InterfaceServicos;

namespace WebAPI_BNB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendamentosController : ControllerBase
    {
        private readonly IAgendamentoService _agendamentoService;
        public AgendamentosController(IAgendamentoService agendamento)
        {
            _agendamentoService = agendamento;
        }

        // GET: api/Agendamentos
        [HttpGet]
        public async Task<IEnumerable<Agendamento>> GetAgendamentos()
        {
            var agendamento = await _agendamentoService.ObterTodos();
            return agendamento;
        }

        // POST: api/Agendamentos
        [HttpPost]
        public async Task<ActionResult<Agendamento>> PostAgendamento(Agendamento agendamento)
        {
            agendamento.HorarioInicial = agendamento.Data;
            agendamento.HorarioDeTermino = agendamento.Data.AddHours(1);
            var resultHora = agendamento.HorarioDeTermino.AddMinutes(30);
            var horarioValido = _agendamentoService.HorarioValido(agendamento.Data);
            var horarioVago = _agendamentoService.HorarioVago(resultHora.TimeOfDay, agendamento.HorarioInicial.TimeOfDay);

            if (horarioValido && horarioVago)
            {
                await _agendamentoService.Salvar(agendamento);
               
                return CreatedAtAction("GetAgendamentos", new { id = agendamento.Id }, agendamento);
            }
            else
            {
                return null;
            }
        }

    }
}
