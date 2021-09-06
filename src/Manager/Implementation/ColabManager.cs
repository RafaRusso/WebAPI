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

        public async Task<IEnumerable<Colab>> GetColabsAsync()
        {
            return await colabRepository.GetColabsAsync();
        }

        public async Task<Colab> GetColabAsync(int id)
        {
            return await colabRepository.GetColabAsync(id);
        }

        public async Task DeleteColabAsync(int id)
        {
            await colabRepository.DeleteColabAsync(id);
        }

        public async Task<Colab> InsertColabAsync(NovoColab novoColab)
        {
            var colab = mapper.Map<Colab>(novoColab);
            return await colabRepository.InsertColabAsync(colab);
        }

        public async Task<Colab> UpdateColabAsync(AlteraColab alteraColab)
        {
            var colab = mapper.Map<Colab>(alteraColab);
            return await colabRepository.UpdateColabAsync(colab);
        }
    }
}
