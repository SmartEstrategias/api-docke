using System.Collections.Generic;
using System.Threading.Tasks;
using src.newDockeNet.Core.ChangeModelsView;
using src.newDockeNet.Core.Models;
using src.newDockeNet.Core.ModelsViewNew;

namespace src.newDockeNet.Manager.Managment
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