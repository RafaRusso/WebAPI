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
            return await context.Colabs.AsNoTracking().ToListAsync();
        }

        public async Task<Colab> GetColabAsync(int id)
        {
            return await context.Colabs.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        //insert
        public async Task<Colab> InsertColabAsync(Colab colab)
        {
            await context.Colabs.AddAsync(colab);
            await context.SaveChangesAsync();
            return colab;
        }

        
        //update
        public async Task<Colab> UpdateColabAsync(Colab colab)
        {
            var colabConsultado = await context.Colabs.SingleOrDefaultAsync(p => p.Id == colab.Id);
            if (colabConsultado == null)
            {
                return null;
            }
            context.Entry(colabConsultado).CurrentValues.SetValues(colab);
            await context.SaveChangesAsync();
            return colabConsultado;
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
