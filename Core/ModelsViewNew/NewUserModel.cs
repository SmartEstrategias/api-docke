using newDockeNet.Core.Models;

namespace newDockeNet.Core.ModelsViewNew
{
    public class NewUserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public NewCompanyModel Company { get; set; }
        public NewDpoModel DPO { get; set; }
    }
}