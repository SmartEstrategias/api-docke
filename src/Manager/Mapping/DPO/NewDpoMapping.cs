using AutoMapper;
using src.newDockeNet.Core.Models;
using src.newDockeNet.Core.ModelsViewNew;

namespace src.newDockeNet.Manager.Mapping.DPO
{
    public class NewDpoMapping : Profile
    {
        public NewDpoMapping()
        {
            CreateMap<NewDpoModel, DPOModel>();
        }
    }
}