using AutoMapper;
using RelatorioProject.Dtos;
using RelatorioProject.Model;

namespace RelatorioProject.Profiles
{
    public class RelatorioProfile: Profile
    {
        public RelatorioProfile()
        {
            CreateMap<Relatorio,RelatorioReadDto>();
            CreateMap<RelatorioCreateDto,Relatorio>();
        }
    }
}