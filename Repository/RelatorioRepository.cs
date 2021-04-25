using System;
using System.Collections.Generic;
using System.Linq;
using RelatorioProject.Dtos;
using RelatorioProject.Model;

namespace RelatorioProject.Repository
{
    public class RelatorioRepository : IRelatorioRepository
    {
        private readonly RelatorioContext _context;

        public RelatorioRepository(RelatorioContext context)
        {
            _context = context;
        }

        public void AddRelatorio(Relatorio relatorio)
        {
            if (relatorio == null)
            {
                throw new ArgumentNullException(nameof(relatorio));
            }
            _context.Add(relatorio);
        }

        public Relatorio GetRelatorioById(int id )
        {
            return _context.Relatorio.FirstOrDefault(re => re.Id == id);
        }

        public IEnumerable<Relatorio> GetRelatorios()
        {
            return _context.Relatorio.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}