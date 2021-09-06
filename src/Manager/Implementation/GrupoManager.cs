using Core.Domain;
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

        public GrupoManager(IGrupoRepository grupoRepository)
        {
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

        public async Task<Grupo> InsertGrupoAsync(Grupo grupo)
        {
            return await grupoRepository.InsertGrupoAsync(grupo);
        }

        public async Task<Grupo> UpdateGrupoAsync(Grupo grupo)
        {
            return await grupoRepository.UpdateGrupoAsync(grupo);
        }
    }
}
