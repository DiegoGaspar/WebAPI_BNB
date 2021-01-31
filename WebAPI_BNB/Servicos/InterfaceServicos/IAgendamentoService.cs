/************************
 *Criado por Diego Gaspar
 ************************/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI_BNB.Models;

namespace WebAPI_BNB.Servicos.InterfaceServicos
{
    public interface IAgendamentoService : IServico<Agendamento>
    {

        bool HorarioValido(DateTime horario);

        bool HorarioVago(TimeSpan a, TimeSpan b);


    }
}
