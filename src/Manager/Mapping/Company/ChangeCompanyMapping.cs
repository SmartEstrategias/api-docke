using AutoMapper;
using src.newDockeNet.Core.ChangeModelsView;
using src.newDockeNet.Core.Models;

namespace src.newDockeNet.Manager.Mapping.Company
{
    public class ChangeCompanyMapping : Profile
    {
        public ChangeCompanyMapping()
        {
            CreateMap<ChangeCompanyModel, CompanyModel>();
        }
    }
}