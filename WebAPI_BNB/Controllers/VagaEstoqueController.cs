using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_BNB.Configuracao;
using WebAPI_BNB.Models;

namespace WebAPI_BNB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagaEstoqueController : ControllerBase
    {
        private readonly EstoqueContext _context;

        public VagaEstoqueController(EstoqueContext context)
        {
            _context = context;
        }

        // GET: api/VagaEstoque
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VagaEstoque>>> GetVagasEstoque()
        {
            return await _context.VagasEstoque.ToListAsync();
        }

        // GET: api/VagaEstoque/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VagaEstoque>> GetVagaEstoque(int id)
        {
            var vagaEstoque = await _context.VagasEstoque.FindAsync(id);

            if (vagaEstoque == null)
            {
                return NotFound();
            }

            return vagaEstoque;
        }

        // PUT: api/VagaEstoque/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVagaEstoque(int id, VagaEstoque vagaEstoque)
        {
            if (id != vagaEstoque.Id)
            {
                return BadRequest();
            }

            _context.Entry(vagaEstoque).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VagaEstoqueExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/VagaEstoque
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VagaEstoque>> PostVagaEstoque(VagaEstoque vagaEstoque)
        {
            _context.VagasEstoque.Add(vagaEstoque);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVagaEstoque", new { id = vagaEstoque.Id }, vagaEstoque);
        }

        // DELETE: api/VagaEstoque/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVagaEstoque(int id)
        {
            var vagaEstoque = await _context.VagasEstoque.FindAsync(id);
            if (vagaEstoque == null)
            {
                return NotFound();
            }

            _context.VagasEstoque.Remove(vagaEstoque);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VagaEstoqueExists(int id)
        {
            return _context.VagasEstoque.Any(e => e.Id == id);
        }
    }
}
