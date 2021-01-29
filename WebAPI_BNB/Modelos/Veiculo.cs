/************************
 *Criado por Diego Gaspar
 ************************/

using WebAPI_BNB.Enums.Models;

namespace WebAPI_BNB.Models
{
    /// <summary>
    /// Classse Veiculo - responsável pelas carretas
    /// </summary>
    public class Veiculo : ClasseBase
    {
        //Placa do veículo
        public string Placa { get; set; }

        //Tipo de veículo
        public TipoVeiculo Tipo { get; set; }

        //Tipo de carga
        public int CargaId { get; set; }
    }
}