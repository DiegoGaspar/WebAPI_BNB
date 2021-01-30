/************************
 *Criado por Diego Gaspar
 ************************/

using WebAPI_BNB.Configuracao;

namespace WebAPI_BNB.Repositories
{
    public class Repository
    {
        protected readonly EstoqueContext _context;

        public Repository(EstoqueContext context)
        {
            _context = context;
        }
    }
}
