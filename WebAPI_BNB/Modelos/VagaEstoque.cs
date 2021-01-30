/************************
 *Criado por Diego Gaspar
 ************************/

namespace WebAPI_BNB.Models
{
    /// <summary>
    /// Classse de vagas
    /// </summary>
    public class VagaEstoque : ClasseBase
    {
        //número da vaga de recebimento do estoque
        public int? NumeroVaga { get; set; }
        public string NomeVaga { get; set; }
        public bool Ocupada { get; set; }
    }
}
