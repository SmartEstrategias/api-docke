namespace newDockeNet.Core.Models
{
    public class DPOModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Job { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public string Telephone { get; set; }
        public string Branchline { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
    }
}