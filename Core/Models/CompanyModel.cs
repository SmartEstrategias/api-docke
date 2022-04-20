namespace newDockeNet.Core.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Address { get; set; }
        public string NumberAddress { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Cep { get; set; }
        public string Logo { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
    }
}