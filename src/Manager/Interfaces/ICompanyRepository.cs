using System.Collections.Generic;
using System.Threading.Tasks;
using src.newDockeNet.Core.Models;

namespace src.newDockeNet.Manager.Interfaces
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<CompanyModel>> GetCompanyAsync();
        Task<CompanyModel> GetCompanyByIdAsync(string id);
        Task<CompanyModel> InsertCompanyAsync(CompanyModel company);
        Task<CompanyModel> UpdateCompanyAsync(CompanyModel company);
        Task<CompanyModel> DeleteCompanyAsync(string id);
    }
}