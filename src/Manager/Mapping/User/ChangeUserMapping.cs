using System;
using AutoMapper;
using src.newDockeNet.Core.ChangeModelsView;
using src.newDockeNet.Core.Models;

namespace src.newDockeNet.Manager.Mapping.User
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