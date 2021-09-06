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
        Task<ColabView> GetColabAsync(int id);
        Task<IEnumerable<ColabView>> GetColabsAsync();
        Task<ColabView> InsertColabAsync(NovoColab colabNovo);
        Task<ColabView> UpdateColabAsync(AlteraColab alteraColab);
    }
}
