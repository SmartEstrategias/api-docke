using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;

namespace newDockeNet.Manager.Interfaces
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<CompanyModel>> GetCompanyAsync();
        Task<CompanyModel> GetCompanyByIdAsync(int id);
        Task<CompanyModel> InsertCompanyAsync(CompanyModel company);
        Task<CompanyModel> UpdateCompanyAsync(CompanyModel company);
        Task<CompanyModel> DeleteCompanyAsync(int id);
    }
}