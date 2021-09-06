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
    public class ColabRepository : IColabRepository
    {
        private readonly ColabDBContext context;
        public ColabRepository(ColabDBContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Colab>> GetColabsAsync()
        {
            return await context.Colabs.Include(p =>p.Departamentos).Include(p=>p.Grupos).AsNoTracking().ToListAsync();
        }

        public async Task<Colab> GetColabAsync(int id)
        {
            return await context.Colabs.AsNoTracking().Include(p => p.Departamentos).Include(p => p.Grupos).FirstOrDefaultAsync(c => c.Id == id);
        }

        //insert
        public async Task<Colab> InsertColabAsync(Colab colab)
        {

            await InsertColabDepartamento(colab);
            await InsertColabGrupo(colab);
            await context.Colabs.AddAsync(colab);
            await context.SaveChangesAsync();
            return colab;
        }

        private async Task InsertColabGrupo(Colab colab)
        {
            var gruposConsultados = new List<Grupo>();
            foreach (var grupo in colab.Grupos)
            {
                var grupoConsultado = await context.Grupos.FindAsync(grupo.Id);
                gruposConsultados.Add(grupoConsultado);
            }
            colab.Grupos = gruposConsultados;
        }

        private async Task InsertColabDepartamento(Colab colab)
        {
            var departamentosConsultados = new List<Departamento>();
            foreach (var departamento in colab.Departamentos)
            {
                var departamentoConsultado = await context.Departamentos.FindAsync(departamento.Id);
                departamentosConsultados.Add(departamentoConsultado);
            }
            colab.Departamentos = departamentosConsultados;
        }


        //update
        public async Task<Colab> UpdateColabAsync(Colab colab)
        {
            var colabConsultado = await context.Colabs
                                        .Include(p => p.Departamentos)
                                        .Include(p => p.Grupos)
                                        .SingleOrDefaultAsync(p => p.Id == colab.Id);
            if (colabConsultado == null)
            {
                return null;
            }
            context.Entry(colabConsultado).CurrentValues.SetValues(colab);
            await UpdateColabDepartamentoGrupo(colab, colabConsultado);
            await context.SaveChangesAsync();
            return colabConsultado;
        }

        private async Task UpdateColabDepartamentoGrupo(Colab colab, Colab colabConsultado)
        {
            colabConsultado.Departamentos.Clear();
            colabConsultado.Grupos.Clear();
            foreach (var departamento in colab.Departamentos)
            {
                var departamentoConsultado = await context.Departamentos.FindAsync(departamento.Id);
                colabConsultado.Departamentos.Add(departamentoConsultado);
            }
            foreach (var grupo in colab.Grupos)
            {
                var grupoConsultado = await context.Grupos.FindAsync(grupo.Id);
                colabConsultado.Grupos.Add(grupoConsultado);
            }
        }

        //delete
        public async Task DeleteColabAsync(int id)
        {
            var colabConsultado = await context.Colabs.FindAsync(id);
            context.Colabs.Remove(colabConsultado);
            await context.SaveChangesAsync();
        }
    }
}
