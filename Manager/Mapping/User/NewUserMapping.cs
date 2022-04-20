using AutoMapper;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;

namespace newDockeNet.Manager.Mapping.User
{
    public class NewUserMapping : Profile
    {
        public NewUserMapping()
        {
            CreateMap<NewUserModel, UserModel>()
            .ForMember(d => d.createdAt, o => o.MapFrom(x => DateTime.Now));

            CreateMap<NewDpoModel, DPOModel>();

            CreateMap<NewCompanyModel, CompanyModel>();
        }
    }
}