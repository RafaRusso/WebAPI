using Core.Domain;
using Core.Shared.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Interfaces
{
    public interface IDepartamentoManager
    {
        Task DeleteDepartamentoAsync(int id);
        Task<Departamento> GetDepartamentoAsync(int id);
        Task<IEnumerable<Departamento>> GetDepartamentosAsync();
        Task<Departamento> InsertDepartamentoAsync(NovoDepartamento novoDepartamento);
        Task<Departamento> UpdateDepartamentoAsync(AlteraDepartamento alteraDepartamento);
    }
}
