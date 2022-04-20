using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;

namespace newDockeNet.Manager.Managment
{
    public interface ICompanyManager
    {
        Task<IEnumerable<CompanyModel>> GetCompanyAsync();
        Task<CompanyModel> GetCompanyByIdAsync(string id);
        Task<CompanyModel> InsertCompanyAsync(NewCompanyModel newCompany);
        Task<CompanyModel> UpdateCompanyAsync(ChangeCompanyModel changeCompany);
        Task<CompanyModel> DeleteCompanyAsync(string id);
    }
}