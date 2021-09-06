using AutoMapper;
using Core.Domain;
using Core.Shared.ModelViews;
using Core.Shared.ModelViews.Colab;
using Manager.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Manager.Implementation
{
    public class ColabManager : IColabManager
    {
        private readonly IColabRepository colabRepository;
        private readonly IMapper mapper;

        public ColabManager(IColabRepository colabRepository, IMapper mapper)
        {
            this.colabRepository = colabRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ColabView>> GetColabsAsync()
        {
            return mapper.Map<IEnumerable<Colab>,IEnumerable<ColabView>>(await colabRepository.GetColabsAsync());
        }

        public async Task<ColabView> GetColabAsync(int id)
        {
            return mapper.Map < ColabView > (await colabRepository.GetColabAsync(id));
        }

        public async Task DeleteColabAsync(int id)
        {
            await colabRepository.DeleteColabAsync(id);
        }

        public async Task<ColabView> InsertColabAsync(NovoColab novoColab)
        {
            var colab = mapper.Map<Colab>(novoColab);
            return mapper.Map<ColabView>(await colabRepository.InsertColabAsync(colab));
        }

        public async Task<ColabView> UpdateColabAsync(AlteraColab alteraColab)
        {
            var colab = mapper.Map<Colab>(alteraColab);
            return mapper.Map < ColabView >(await colabRepository.UpdateColabAsync(colab));
        }
    }
}
