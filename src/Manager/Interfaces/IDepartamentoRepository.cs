using Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Interfaces
{
    public interface IDepartamentoRepository
    {
        Task DeleteDepartamentoAsync(int id);
        Task<Departamento> GetDepartamentoAsync(int id);
        Task<IEnumerable<Departamento>> GetDepartamentosAsync();
        Task<Departamento> InsertDepartamentoAsync(Departamento departamento);
        Task<Departamento> UpdateDepartamentoAsync(Departamento departamento);
    }
}
