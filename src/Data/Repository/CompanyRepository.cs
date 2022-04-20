using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src.newDockeNet.Core.Models;
using src.newDockeNet.Data.Context;
using src.newDockeNet.Manager.Interfaces;

namespace src.newDockeNet.Data.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DockeContext context;
        public CompanyRepository(DockeContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<CompanyModel>> GetCompanyAsync()
        {
            return await context.Companys.AsNoTracking().ToListAsync();
        }

        public async Task<CompanyModel> GetCompanyByIdAsync(string id)
        {
            return await context.Companys.FindAsync(id);
        }

        public async Task<CompanyModel> InsertCompanyAsync(CompanyModel company)
        {
            await context.Companys.AddAsync(company);
            await context.SaveChangesAsync();
            return company;
        }

        public async Task<CompanyModel> UpdateCompanyAsync(CompanyModel company)
        {
            var updateCompany = await context.Companys.FindAsync(company.CompanyId);

            if (updateCompany == null) return null;

            context.Entry(updateCompany).CurrentValues.SetValues(company);
            await context.SaveChangesAsync();
            return company;
        }

        public async Task<CompanyModel> DeleteCompanyAsync(string id)
        {
            var deletedCompany = await context.Companys.FindAsync(id);

            if (deletedCompany == null) return null;

            context.Companys.Remove(deletedCompany);
            await context.SaveChangesAsync();
            return deletedCompany;
        }
    }
}