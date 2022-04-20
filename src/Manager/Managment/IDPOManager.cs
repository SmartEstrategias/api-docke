using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;

namespace newDockeNet.Manager.Managment
{
    public interface IDPOManager
    {
        Task<IEnumerable<DPOModel>> GetDpoAsync();
        Task<DPOModel> GetDpoByIdAsync(string id);
        Task<DPOModel> InsertDpoAsync(NewDpoModel newDpo);
        Task<DPOModel> UpdateDpoAsync(ChangeDpoModel changeDpo);
        Task<DPOModel> DeleteDpoAsync(string id);
    }
}