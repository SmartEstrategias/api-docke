using System;
using AutoMapper;
using src.newDockeNet.Core.Models;
using src.newDockeNet.Core.ModelsViewNew;

namespace src.newDockeNet.Manager.Mapping.User
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