using System.Collections.Generic;
using System.Threading.Tasks;
using src.newDockeNet.Core.Models;

namespace src.newDockeNet.Manager.Interfaces
{
    public interface IDpoRepository
    {
        Task<IEnumerable<DPOModel>> GetDpoAsync();
        Task<DPOModel> GetDpoByIdAsync(string id);
        Task<DPOModel> InsertDpoAsync(DPOModel dpo);
        Task<DPOModel> UpdateDpoAsync(DPOModel dpo);
        Task<DPOModel> DeleteDpoAsync(string id);
    }
}