using AutoMapper;
using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;

namespace newDockeNet.Manager.Mapping.DPO
{
    public class ChangeDpoMapping : Profile
    {
        public ChangeDpoMapping()
        {
            CreateMap<ChangeDpoModel, DPOModel>();
        }
    }
}