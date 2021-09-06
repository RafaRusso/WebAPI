using AutoMapper;
using Core.Domain;
using Core.Shared.ModelViews;
using Core.Shared.ModelViews.Colab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Mappings
{
    public class AlteraColabMappingProfile : Profile
    {
        public AlteraColabMappingProfile()
        {
            CreateMap<Colab, AlteraColab>().ReverseMap();
        }
    }
}
