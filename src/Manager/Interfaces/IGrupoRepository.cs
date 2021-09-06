using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Interfaces
{
    public interface IGrupoRepository
    {
        Task<bool> ExisteAsync(int id);
        Task DeleteGrupoAsync(int id);
        Task<Grupo> GetGrupoAsync(int id);
        Task<IEnumerable<Grupo>> GetGruposAsync();
        Task<Grupo> InsertGrupoAsync(Grupo grupo);
        Task<Grupo> UpdateGrupoAsync(Grupo grupo);
    }
}
