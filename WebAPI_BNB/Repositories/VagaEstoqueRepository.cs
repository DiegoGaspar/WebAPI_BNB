/************************
 *Criado por Diego Gaspar
 ************************/

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI_BNB.Configuracao;
using WebAPI_BNB.Models;
using WebAPI_BNB.Repositories.Interfaces;

namespace WebAPI_BNB.Repositories
{
    public class VagaEstoqueRepository : Repository, IVagaEstoqueRepository
    {
        public VagaEstoqueRepository(EstoqueContext context) : base(context)
        { }

        public async Task<IEnumerable<VagaEstoque>> ListAsync()
        {
            return await _context.VagasEstoque.ToListAsync();
        }

        public async Task AddAsync(VagaEstoque ve)
        {
            await _context.VagasEstoque.AddAsync(ve);
        }

        public async Task<VagaEstoque> FindByIdAsync(int id)
        {
            return await _context.VagasEstoque.FindAsync(id);
        }

        public void Remove(VagaEstoque ve)
        {
            _context.VagasEstoque.Remove(ve);
        }

        public void Update(VagaEstoque ve)
        {
            _context.VagasEstoque.Update(ve);
        }

    }
}
