using Core.Domain;
using Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Implementation
{
    public class DepartamentoManager : IDepartamentoManager
    {
        private readonly IDepartamentoRepository departamentoRepository;

        public DepartamentoManager(IDepartamentoRepository departamentoRepository)
        {
            this.departamentoRepository = departamentoRepository;
        }
        public async Task DeleteDepartamentoAsync(int id)
        {
            await departamentoRepository.DeleteDepartamentoAsync(id);
        }

        public async Task<IEnumerable<Departamento>> GetDepartamentosAsync()
        {
            return await departamentoRepository.GetDepartamentosAsync();
        }


        public async Task<Departamento> GetDepartamentoAsync(int id)
        {
            return await departamentoRepository.GetDepartamentoAsync(id);
        }

        public async Task<Departamento> InsertDepartamentoAsync(Departamento departamento)
        {
            return await departamentoRepository.InsertDepartamentoAsync(departamento);
        }

        public async Task<Departamento> UpdateDepartamentoAsync(Departamento departamento)
        {
            return await departamentoRepository.UpdateDepartamentoAsync(departamento);
        }
    }
}
