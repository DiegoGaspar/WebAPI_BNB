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
    public class AgendamentoRepository : Repository, IAgendamentoRepository
    {
        public AgendamentoRepository(EstoqueContext context) : base(context)
        { }

        public async Task<IEnumerable<Agendamento>> ListAsync()
        {
            return await _context.Agendamentos.ToListAsync();
        }

        public async Task AddAsync(Agendamento categoria)
        {
            await _context.Agendamentos.AddAsync(categoria);
        }

        public async Task<Agendamento> FindByIdAsync(int id)
        {
            return await _context.Agendamentos.FindAsync(id);
        }

        public void Remove(Agendamento categoria)
        {
            _context.Agendamentos.Remove(categoria);
        }

        public void Update(Agendamento categoria)
        {
            _context.Agendamentos.Update(categoria);
        }

    }
}
