using AutoMapper;
using src.newDockeNet.Core.Models;
using src.newDockeNet.Core.ModelsViewNew;

namespace src.newDockeNet.Manager.Mapping.Company
{
    public class NewCompanyMapping : Profile
    {
        public NewCompanyMapping()
        {
            CreateMap<NewCompanyModel, CompanyModel>();
        }
    }
}