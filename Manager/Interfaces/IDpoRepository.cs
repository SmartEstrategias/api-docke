using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;

namespace newDockeNet.Manager.Interfaces
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