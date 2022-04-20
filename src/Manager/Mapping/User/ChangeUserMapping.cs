using AutoMapper;
using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;

namespace newDockeNet.Manager.Mapping.User
{
    public class ChangeUserMapping : Profile
    {
        public ChangeUserMapping()
        {
            CreateMap<ChangeUserModel, UserModel>()
            .ForMember(d => d.updatedAt, o => o.MapFrom(x => DateTime.Now));

            CreateMap<ChangeDpoModel, DPOModel>();

            CreateMap<ChangeCompanyModel, CompanyModel>();
        }
    }
}