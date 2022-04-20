using System;
namespace src.newDockeNet.Core.ModelsViewNew
{
    public class NewUserModel
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string EmailSecondary { get; set; }
        public string CPF { get; set; }
        public string Cellphone { get; set; }
        public string Telephone { get; set; }
        public DateTime? Birthday { get; set; }
    }
}