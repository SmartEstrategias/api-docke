using AutoMapper;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;

namespace newDockeNet.Manager.Mapping.Company
{
    public class NewCompanyMapping : Profile
    {
        public NewCompanyMapping()
        {
            CreateMap<NewCompanyModel, CompanyModel>();
        }
    }
}