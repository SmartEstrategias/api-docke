using System.Collections.Generic;
using System.Threading.Tasks;
using src.newDockeNet.Core.ChangeModelsView;
using src.newDockeNet.Core.Models;
using src.newDockeNet.Core.ModelsViewNew;

namespace src.newDockeNet.Manager.Managment
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