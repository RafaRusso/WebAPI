using AutoMapper;
using Core.Domain;
using Core.Shared.ModelViews;
using Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Implementation
{
    public class GrupoManager : IGrupoManager
    {
        private readonly IGrupoRepository grupoRepository;
        private readonly IMapper mapper;

        public GrupoManager(IGrupoRepository grupoRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.grupoRepository = grupoRepository;
        }
        public async Task DeleteGrupoAsync(int id)
        {
            await grupoRepository.DeleteGrupoAsync(id);
        }

        public async Task<Grupo> GetGrupoAsync(int id)
        {
            return await grupoRepository.GetGrupoAsync(id);
        }

        public async Task<IEnumerable<Grupo>> GetGruposAsync()
        {
            return await grupoRepository.GetGruposAsync();
        }

        public async Task<Grupo> InsertGrupoAsync(NovoGrupo novoGrupo)
        {
            var grupo = mapper.Map<Grupo>(novoGrupo);
            return await grupoRepository.InsertGrupoAsync(grupo);
        }

        public async Task<Grupo> UpdateGrupoAsync(AlteraGrupo alteraGrupo)
        {
            var grupo = mapper.Map<Grupo>(alteraGrupo);
            return await grupoRepository.UpdateGrupoAsync(grupo);
        }
    }
}
