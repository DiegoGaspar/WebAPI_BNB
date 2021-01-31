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
    public class VagaEstoqueService : IVagaEstoqueService
    {
        private readonly IVagaEstoqueRepository _vagaEstoqueRepository;
        public VagaEstoqueService(IVagaEstoqueRepository vagaEstoqueRepository)
        {
            _vagaEstoqueRepository = vagaEstoqueRepository;
        }

        public int Excluir(int id)
        {
            throw new NotImplementedException();
        }
     
        VagaEstoque IServico<VagaEstoque>.ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<VagaEstoque>> IServico<VagaEstoque>.ObterTodos()
        {
            throw new NotImplementedException();
        }

        Task IServico<VagaEstoque>.Salvar(VagaEstoque ent)
        {
            throw new NotImplementedException();
        }
    }
}
