using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RelatorioProject.Model;
using RelatorioProject.Repository;

namespace RelatorioProject.Controller
{
    [Route("api/relatorios")]
    [ApiController]
    public class RelatorioController : ControllerBase
    {
        private readonly IRelatorioRepository _rep;

        public RelatorioController(IRelatorioRepository rep)
        {
            _rep = rep;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Relatorio>> GetAllRelatorios( )
        {
            var relatorios = _rep.GetRelatorios();
            return Ok(relatorios);
        }

        [HttpGet("{id}")]
        public ActionResult<Relatorio> GetRelatorioById(int id)
        {
            var relatorio = _rep.GetRelatorioById(id);
            return Ok(relatorio);
        }

        [HttpPost]
        public ActionResult AdicionarRelatorio(Relatorio relatorio)
        {
           _rep.AddRelatorio(relatorio);
           _rep.SaveChanges();
           return Ok(relatorio);
        }
    }
}