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
    public class AlteraDepartamentoMappingProfile : Profile
    {
        public AlteraDepartamentoMappingProfile()
        {
            CreateMap<Departamento, AlteraDepartamento>().ReverseMap();
        }
    }
}
