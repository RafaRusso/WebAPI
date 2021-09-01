using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColabAPI.Models;

namespace Repositorio.Repositories
{
    interface IColabRepository
    {
        Task<Colab> Get(int id);
        Task<IEnumerable<Colab>> GetAll();
        Task Add(Colab colab);
        Task Delete(int id);
        Task Update(Colab colab);
    }
}
