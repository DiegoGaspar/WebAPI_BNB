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
    public class TipoDeCargaController : ControllerBase
    {
        private readonly EstoqueContext _context;

        public TipoDeCargaController(EstoqueContext context)
        {
            _context = context;
        }

        // GET: api/TipoDeCarga
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoDeCarga>>> GetTiposDeCargas()
        {
            return await _context.TiposDeCargas.ToListAsync();
        }

        // GET: api/TipoDeCarga/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoDeCarga>> GetTipoDeCarga(int id)
        {
            var tipoDeCarga = await _context.TiposDeCargas.FindAsync(id);

            if (tipoDeCarga == null)
            {
                return NotFound();
            }

            return tipoDeCarga;
        }

        // PUT: api/TipoDeCarga/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoDeCarga(int id, TipoDeCarga tipoDeCarga)
        {
            if (id != tipoDeCarga.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoDeCarga).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoDeCargaExists(id))
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

        // POST: api/TipoDeCarga
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TipoDeCarga>> PostTipoDeCarga(TipoDeCarga tipoDeCarga)
        {
            _context.TiposDeCargas.Add(tipoDeCarga);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoDeCarga", new { id = tipoDeCarga.Id }, tipoDeCarga);
        }

        // DELETE: api/TipoDeCarga/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoDeCarga(int id)
        {
            var tipoDeCarga = await _context.TiposDeCargas.FindAsync(id);
            if (tipoDeCarga == null)
            {
                return NotFound();
            }

            _context.TiposDeCargas.Remove(tipoDeCarga);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TipoDeCargaExists(int id)
        {
            return _context.TiposDeCargas.Any(e => e.Id == id);
        }
    }
}
