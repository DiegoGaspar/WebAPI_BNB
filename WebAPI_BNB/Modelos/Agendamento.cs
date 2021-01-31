/************************
 *Criado por Diego Gaspar
 ************************/

using System;

namespace WebAPI_BNB.Models
{
    /// <summary>
    /// Classse responsável pelos agendamentos das descargas
    /// </summary>
    public class Agendamento : Entidade
    {
        //Data do agendamento
        public DateTime Data { get; set; }

        //Horário do agendamento
        public DateTime HorarioInicial { get; set; }

        //Horario final do agendamento
        public DateTime HorarioDeTermino { get; set; }

        //Id do veículo que irá realizar a descarga
        public int VeiculoID { get; set; }

    }

}