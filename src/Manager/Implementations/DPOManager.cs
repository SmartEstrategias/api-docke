using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using src.newDockeNet.Core.ChangeModelsView;
using src.newDockeNet.Core.Models;
using src.newDockeNet.Core.ModelsViewNew;
using src.newDockeNet.Manager.Interfaces;
using src.newDockeNet.Manager.Managment;

namespace src.newDockeNet.Manager.Implementations
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

        public async Task<DPOModel> GetDpoByIdAsync(string id)
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

        public async Task<DPOModel> DeleteDpoAsync(string id)
        {
            return await dpoRepository.DeleteDpoAsync(id);
        }
    }
}