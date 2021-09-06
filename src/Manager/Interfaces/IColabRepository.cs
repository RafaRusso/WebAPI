using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Interfaces
{
    public interface IColabRepository
    {
        Task DeleteColabAsync(int id);
        Task<Colab> GetColabAsync(int id);
        Task<IEnumerable<Colab>> GetColabsAsync();
        Task<Colab> InsertColabAsync(Colab colab);
        Task<Colab> UpdateColabAsync(Colab colab);
    }
}
