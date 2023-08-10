using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 
        }


        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
