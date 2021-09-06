using AutoMapper;
using Core.Domain;
using Core.Shared.ModelViews;
using Core.Shared.ModelViews.Colab;
using Core.Shared.ModelViews.Departamento;
using Core.Shared.ModelViews.Grupo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Mappings
{
    public class NovoColabMappingProfile : Profile
    {
        public NovoColabMappingProfile()
        {
            CreateMap<Colab, NovoColab>().ReverseMap();
            CreateMap<Colab, ColabView>();
            CreateMap<Departamento, ReferenciaDepartamento>().ReverseMap();
            CreateMap<Departamento, DepartamentoView>().ReverseMap();
            CreateMap<Grupo, ReferenciaGrupo>().ReverseMap();
            CreateMap<Grupo, GrupoView>().ReverseMap();
            CreateMap<AlteraColab, Colab>().ReverseMap();
        }
    }
}
