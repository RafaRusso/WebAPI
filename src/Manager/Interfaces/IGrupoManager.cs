using Core.Domain;
using Core.Shared.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Interfaces
{
    public interface IGrupoManager
    {
        Task DeleteGrupoAsync(int id);
        Task<Grupo> GetGrupoAsync(int id);
        Task<IEnumerable<Grupo>> GetGruposAsync();
        Task<Grupo> InsertGrupoAsync(NovoGrupo novoGrupo);
        Task<Grupo> UpdateGrupoAsync(AlteraGrupo alteraGrupo);
    }
}
