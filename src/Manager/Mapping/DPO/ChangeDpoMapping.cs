using AutoMapper;
using src.newDockeNet.Core.ChangeModelsView;
using src.newDockeNet.Core.Models;

namespace src.newDockeNet.Manager.Mapping.DPO
{
    public class ChangeDpoMapping : Profile
    {
        public ChangeDpoMapping()
        {
            CreateMap<ChangeDpoModel, DPOModel>();
        }
    }
}