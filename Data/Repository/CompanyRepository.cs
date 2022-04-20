using Microsoft.EntityFrameworkCore;
using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;
using newDockeNet.Data.Context;
using newDockeNet.Manager.Interfaces;

namespace newDockeNet.Data.Repository
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