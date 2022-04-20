using AutoMapper;
using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;
using newDockeNet.Manager.Interfaces;
using newDockeNet.Manager.Managment;

namespace newDockeNet.Manager.Implementations
{
    public class CompanyManager : ICompanyManager
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IMapper mapper;
        public CompanyManager(ICompanyRepository companyRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.companyRepository = companyRepository;
        }

        public async Task<IEnumerable<CompanyModel>> GetCompanyAsync()
        {
            return await companyRepository.GetCompanyAsync();
        }

        public async Task<CompanyModel> GetCompanyByIdAsync(string id)
        {
            return await companyRepository.GetCompanyByIdAsync(id);
        }

        public async Task<CompanyModel> InsertCompanyAsync(NewCompanyModel newCompany)
        {
            var company = mapper.Map<CompanyModel>(newCompany);
            return await companyRepository.InsertCompanyAsync(company);
        }

        public async Task<CompanyModel> UpdateCompanyAsync(ChangeCompanyModel changeCompany)
        {
            var company = mapper.Map<CompanyModel>(changeCompany);
            return await companyRepository.UpdateCompanyAsync(company);
        }

        public async Task<CompanyModel> DeleteCompanyAsync(string id)
        {
            return await companyRepository.DeleteCompanyAsync(id);
        }
    }
}