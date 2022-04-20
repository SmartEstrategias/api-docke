using AutoMapper;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;

namespace newDockeNet.Manager.Mapping.DPO
{
    public class NewDpoMapping : Profile
    {
        public NewDpoMapping()
        {
            CreateMap<NewDpoModel, DPOModel>();
        }
    }
}