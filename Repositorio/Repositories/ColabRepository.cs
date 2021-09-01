using ColabAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Repositories
{
    class ColabRepository : IColabRepository
    {
        public Task Add(Colab colab)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Colab> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Colab>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Colab colab)
        {
            throw new NotImplementedException();
        }
    }
}
