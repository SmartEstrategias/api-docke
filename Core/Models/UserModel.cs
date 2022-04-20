namespace newDockeNet.Core.Models
{
    public class UserModel
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string EmailSecondary { get; set; }
        public string CPF { get; set; }
        public string Cellphone { get; set; }
        public string Telephone { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}