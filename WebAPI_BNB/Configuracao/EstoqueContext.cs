using Microsoft.EntityFrameworkCore;
using WebAPI_BNB.Models;

namespace WebAPI_BNB.Configuracao
{
    public class EstoqueContext : DbContext
    {
        //Cria a base de dados caso não haja 
        public EstoqueContext(DbContextOptions<EstoqueContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        #region Classes mapeadas para o banco
        public DbSet<Agendamento> Agendamentos { get; set; }
        public DbSet<VagaEstoque> VagasEstoque { get; set; }
        public DbSet<TipoDeCarga> TiposDeCargas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        #endregion

    }
}