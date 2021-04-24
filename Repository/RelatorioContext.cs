using Microsoft.EntityFrameworkCore;
using RelatorioProject.Model;

namespace RelatorioProject.Repository
{
    public class RelatorioContext : DbContext
    {
        
        public RelatorioContext(DbContextOptions<RelatorioContext> options) : base(options)
        {

        }
        public DbSet<Relatorio> Relatorio { get; set; }
        
    }
}