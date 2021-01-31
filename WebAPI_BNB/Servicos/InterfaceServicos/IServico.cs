/************************
 *Criado por Diego Gaspar
 ************************/

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_BNB.Models;

namespace WebAPI_BNB.Servicos.InterfaceServicos
{
    public interface IServico<TEntidade>
        where TEntidade : Entidade
    {
        TEntidade ObterPorId(int id);
        Task<IEnumerable<TEntidade>> ObterTodos();
        int Excluir(int id);
        Task Salvar(TEntidade ent);
    }
}