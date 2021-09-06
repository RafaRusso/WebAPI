using Core.Domain;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager.Interfaces;

namespace Data.Repository
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private readonly ColabDBContext context;
        public DepartamentoRepository(ColabDBContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Departamento>> GetDepartamentosAsync()
        {
            return await context.Departamentos.AsNoTracking().ToListAsync();
        }

        public async Task<Departamento> GetDepartamentoAsync(int id)
        {
            return await context.Departamentos.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        //insert
        public async Task<Departamento> InsertDepartamentoAsync(Departamento departamento)
        {
            await context.Departamentos.AddAsync(departamento);
            await context.SaveChangesAsync();
            return departamento;
        }
        //update
        public async Task<Departamento> UpdateDepartamentoAsync(Departamento departamento)
        {
            var departamentoConsultado = await context.Departamentos.FindAsync(departamento.Id);
            if (departamentoConsultado == null)
            {
                return null;
            }
            context.Entry(departamentoConsultado).CurrentValues.SetValues(departamento);

            await context.SaveChangesAsync();
            return departamentoConsultado;
        }
        //delete
        public async Task DeleteDepartamentoAsync(int id)
        {
            var departamentoConsultado = await context.Departamentos.FindAsync(id);
            context.Departamentos.Remove(departamentoConsultado);
            await context.SaveChangesAsync();
        }
    }
}
