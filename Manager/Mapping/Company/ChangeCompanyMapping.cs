using AutoMapper;
using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;

namespace newDockeNet.Manager.Mapping.Company
{
    public class ChangeCompanyMapping : Profile
    {
        public ChangeCompanyMapping()
        {
            CreateMap<ChangeCompanyModel, CompanyModel>();
        }
    }
}