using Loja_Virtual_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Loja_Virtual_MVC.Data
{
    public class BancoDeDadosContext : DbContext
    {
        public BancoDeDadosContext(DbContextOptions<BancoDeDadosContext> options) : base(options)
        { 
        }

        public DbSet<ProdutoModel> Produtos { get; set; }
    }
}
