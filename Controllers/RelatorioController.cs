using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RelatorioProject.Dtos;
using RelatorioProject.Model;
using RelatorioProject.Repository;

namespace RelatorioProject.Controller
{
    [Route("api/relatorios")]
    [ApiController]
    public class RelatorioController : ControllerBase
    {
        private readonly IRelatorioRepository _rep;
        private readonly IMapper _mapper;

        public RelatorioController(IRelatorioRepository rep, IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Relatorio>> GetAllRelatorios( )
        {
            var relatorios = _rep.GetRelatorios();
            return Ok(_mapper.Map<IEnumerable<RelatorioReadDto>>(relatorios));
        }

        [HttpGet("{id}")]
        public ActionResult<RelatorioReadDto> GetRelatorioById(int id)
        {
            var relatorio = _rep.GetRelatorioById(id);
            return Ok(_mapper.Map<RelatorioReadDto>(relatorio));
        }

        [HttpPost]
        public ActionResult AdicionarRelatorio(RelatorioCreateDto relatorioCreate)
        {   
            var relatorio = _mapper.Map<Relatorio>(relatorioCreate);
           _rep.AddRelatorio(relatorio);
           _rep.SaveChanges();
           return Ok();
        }
    }
}