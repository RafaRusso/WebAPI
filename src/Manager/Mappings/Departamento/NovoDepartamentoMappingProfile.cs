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
    public class NovoDepartamentoMappingProfile : Profile
    {
        public NovoDepartamentoMappingProfile()
        {
            CreateMap<NovoDepartamento, Departamento>();
        }
    }
}
