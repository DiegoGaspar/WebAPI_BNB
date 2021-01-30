/************************
 *Criado por Diego Gaspar
 ************************/

namespace WebAPI_BNB.Models
{
    /// <summary>
    /// Tipo de carga que o veículo transporta
    /// </summary>
    public class TipoDeCarga : ClasseBase
    {
        //Descrição da carga
        public string Descricao { get; set; }

        //Quantidade de mercadoria
        //public int Quantidade { get; set; }
    }
}
