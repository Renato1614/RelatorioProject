using System.Collections.Generic;
using RelatorioProject.Model;

namespace RelatorioProject.Repository
{
    public interface IRelatorioRepository
    {
        bool SaveChanges();
        IEnumerable<Relatorio> GetRelatorios();
        Relatorio GetRelatorioById(int id);        
        void AddRelatorio(Relatorio relatorio);
    }
}