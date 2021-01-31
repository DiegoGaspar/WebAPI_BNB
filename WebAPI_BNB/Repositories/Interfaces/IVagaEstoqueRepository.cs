/************************
 *Criado por Diego Gaspar
 ************************/

using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI_BNB.Models;

namespace WebAPI_BNB.Repositories.Interfaces
{
    public interface IVagaEstoqueRepository
    {
        Task<IEnumerable<VagaEstoque>> ListAsync();
        Task AddAsync(VagaEstoque ve);
        Task<VagaEstoque> FindByIdAsync(int id);
        void Update(VagaEstoque ve);
        void Remove(VagaEstoque ve);
    }
}
