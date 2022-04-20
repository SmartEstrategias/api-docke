using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src.newDockeNet.Core.Models;
using src.newDockeNet.Data.Context;
using src.newDockeNet.Manager.Interfaces;

namespace src.newDockeNet.Data.Repository
{
    public class DPORepository : IDpoRepository
    {
        private readonly DockeContext context;
        public DPORepository(DockeContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<DPOModel>> GetDpoAsync()
        {
            return await context.DPOs.AsNoTracking().ToListAsync();
        }

        public async Task<DPOModel> GetDpoByIdAsync(string id)
        {
            return await context.DPOs.FindAsync(id);
        }

        public async Task<DPOModel> InsertDpoAsync(DPOModel dpo)
        {
            await context.DPOs.AddAsync(dpo);
            await context.SaveChangesAsync();
            return dpo;
        }

        public async Task<DPOModel> UpdateDpoAsync(DPOModel dpo)
        {
            var updatedDpo = await context.DPOs.FindAsync(dpo.DpoId);

            if (updatedDpo == null) return null;

            context.Entry(updatedDpo).CurrentValues.SetValues(dpo);
            await context.SaveChangesAsync();
            return dpo;
        }

        public async Task<DPOModel> DeleteDpoAsync(string id)
        {
            var deletedDpo = await context.DPOs.FindAsync(id);

            if (deletedDpo == null) return null;

            context.DPOs.Remove(deletedDpo);
            await context.SaveChangesAsync();
            return deletedDpo;
        }
    }
}