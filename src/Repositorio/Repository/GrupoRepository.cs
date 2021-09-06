using Core.Domain;
using Data.Context;
using Manager.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class GrupoRepository : IGrupoRepository
    {
        private readonly ColabDBContext context;
        public GrupoRepository(ColabDBContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Grupo>> GetGruposAsync()
        {
            return await context.Grupos.AsNoTracking().ToListAsync();
        }

        public async Task<Grupo> GetGrupoAsync(int id)
        {
            return await context.Grupos.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        //inset
        public async Task<Grupo> InsertGrupoAsync(Grupo grupo)
        {
            await context.Grupos.AddAsync(grupo);
            await context.SaveChangesAsync();
            return grupo;
        }
        //update
        public async Task<Grupo> UpdateGrupoAsync(Grupo grupo)
        {
            var grupoConsultado = await context.Grupos.FindAsync(grupo.Id);
            if (grupoConsultado == null)
            {
                return null;
            }
            context.Entry(grupoConsultado).CurrentValues.SetValues(grupo);

            await context.SaveChangesAsync();
            return grupoConsultado;
        }
        //delete
        public async Task DeleteGrupoAsync(int id)
        {
            var grupoConsultado = await context.Grupos.FindAsync(id);
            context.Grupos.Remove(grupoConsultado);
            await context.SaveChangesAsync();
        }
    }
}
