using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Context
{
    public class CadastroUsuarioContext : DbContext
    {
        public CadastroUsuarioContext(DbContextOptions options) : base(options) { }

        public DbSet<CadastroUsuarioEntity> CadastroUsuarioEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
