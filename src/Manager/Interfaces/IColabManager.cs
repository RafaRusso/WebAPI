using Core.Domain;
using Core.Shared.ModelViews;
using Core.Shared.ModelViews.Colab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Interfaces
{
    public interface IColabManager
    {
        Task DeleteColabAsync(int id);
        Task<Colab> GetColabAsync(int id);
        Task<IEnumerable<Colab>> GetColabsAsync();
        Task<Colab> InsertColabAsync(NovoColab colabNovo);
        Task<Colab> UpdateColabAsync(AlteraColab alteraColab);
    }
}
