using AutoMapper;
using Core.Domain;
using Core.Shared.ModelViews;
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
        private readonly IMapper mapper;

        public DepartamentoManager(IDepartamentoRepository departamentoRepository, IMapper mapper)
        {
            this.mapper = mapper;
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

        public async Task<Departamento> InsertDepartamentoAsync(NovoDepartamento novoDepartamento)
        {
            var departamento = mapper.Map<Departamento>(novoDepartamento);
            return await departamentoRepository.InsertDepartamentoAsync(departamento);
        }

        public async Task<Departamento> UpdateDepartamentoAsync(AlteraDepartamento alteraDepartamento)
        {
            var departamento = mapper.Map<Departamento>(alteraDepartamento);
            return await departamentoRepository.UpdateDepartamentoAsync(departamento);
        }
    }
}
