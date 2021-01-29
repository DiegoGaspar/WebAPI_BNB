/************************
 *Criado por Diego Gaspar
 ************************/

using System;

namespace WebAPI_BNB.Models
{
    /// <summary>
    /// Classse responsável pelos agendamentos das descargas
    /// </summary>
    public class Agendamento : ClasseBase
    {
        //Data do agendamento
        public DateTime Data { get; set; }

        //Horário do agendamento
        public string HorarioInicial { get; set; }

        //Horario final do agendamento
        public string HorarioDeTermino { get; set; }

        //Id do veículo que irá realizar a descarga
        public int VeiculoID { get; set; }

    }

}