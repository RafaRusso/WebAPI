using Core.Domain;
using Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Implementation
{
    public class ColabManager : IColabManager
    {
        private readonly IColabRepository colabRepository;

        public ColabManager(IColabRepository colabRepository)
        {
            this.colabRepository = colabRepository;
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

        public async Task<Colab> InsertColabAsync(Colab colab)
        {
            return await colabRepository.InsertColabAsync(colab);
        }

        public async Task<Colab> UpdateColabAsync(Colab colab)
        {
            return await colabRepository.UpdateColabAsync(colab);
        }
    }
}
