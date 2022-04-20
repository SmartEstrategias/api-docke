using AutoMapper;
using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;
using newDockeNet.Manager.Interfaces;
using newDockeNet.Manager.Managment;

namespace newDockeNet.Manager.Implementations
{
    public class DPOManager : IDPOManager
    {
        private readonly IDpoRepository dpoRepository;
        private readonly IMapper mapper;
        public DPOManager(IDpoRepository dpoRepository, IMapper mapper)
        {
            this.mapper = mapper;
            this.dpoRepository = dpoRepository;
        }

        public async Task<IEnumerable<DPOModel>> GetDpoAsync()
        {
            return await dpoRepository.GetDpoAsync();
        }

        public async Task<DPOModel> GetDpoByIdAsync(int id)
        {
            return await dpoRepository.GetDpoByIdAsync(id);
        }

        public async Task<DPOModel> InsertDpoAsync(NewDpoModel newDpo)
        {
            var dpo = mapper.Map<DPOModel>(newDpo);
            return await dpoRepository.InsertDpoAsync(dpo);
        }

        public async Task<DPOModel> UpdateDpoAsync(ChangeDpoModel changeDpo)
        {
            var dpo = mapper.Map<DPOModel>(changeDpo);
            return await dpoRepository.UpdateDpoAsync(dpo);
        }

        public async Task<DPOModel> DeleteDpoAsync(int id)
        {
            return await dpoRepository.DeleteDpoAsync(id);
        }
    }
}