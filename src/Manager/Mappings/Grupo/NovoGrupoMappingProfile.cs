using AutoMapper;
using Core.Domain;
using Core.Shared.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Mappings
{
    public class NovoGrupoMappingProfile : Profile
    {
        public NovoGrupoMappingProfile()
        {
            CreateMap<NovoGrupo, Grupo>();
        }
    }
}
