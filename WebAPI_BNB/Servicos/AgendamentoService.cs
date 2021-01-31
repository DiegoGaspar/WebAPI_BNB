/************************
 *Criado por Diego Gaspar
 ************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_BNB.Controllers;
using WebAPI_BNB.Models;
using WebAPI_BNB.Repositories.Interfaces;
using WebAPI_BNB.Servicos.InterfaceServicos;

namespace WebAPI_BNB.Servicos
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IAgendamentoRepository _agendamentoRepository;
        public AgendamentoService(IAgendamentoRepository agendamentoRepository)
        {
            _agendamentoRepository = agendamentoRepository;
        }

        public async Task<IEnumerable<Agendamento>> ObterTodos()
        {
            return await _agendamentoRepository.ListAsync();
        }

        public int Excluir(int id)
        {
            throw new NotImplementedException();
        }
        public Agendamento ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        //Metodo Salvar
        public async Task Salvar(Agendamento a)
        {
            await _agendamentoRepository.AddAsync(a);
        }

        //Verifica se o horário informado é válido 
        public bool HorarioValido(DateTime horario)
        {
            //Horários de agendametos entre 08 as 12 e 14 as 18 
            DateTime horaInicial = DateTime.Parse("08:00:00");
            DateTime horaIntervalo = DateTime.Parse("12:00:00");
            DateTime horaRetorno = DateTime.Parse("14:00:00");
            DateTime horaFinal = DateTime.Parse("18:00:00");

            if (horario > horaInicial && horario < horaIntervalo || horario > horaRetorno && horario < horaFinal)
            {
                bool horarioValido = true;
                return horarioValido;
            }
            else
            {
                bool horarioValido = false;
                return horarioValido;
            }
        }

        public bool HorarioVago(TimeSpan a, TimeSpan b)
        {            
            if (true)
            {
                return true;

            }
            return false;
        }

    }
}
