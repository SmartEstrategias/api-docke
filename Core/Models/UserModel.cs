namespace newDockeNet.Core.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public int CompanyId { get; set; }
        public CompanyModel Company { get; set; }
        public int DPOId { get; set; }
        public DPOModel DPO { get; set; }
    }
}