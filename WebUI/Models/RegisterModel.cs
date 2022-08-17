using EntityLayer.Entities;

namespace WebUI.Models
{
    public class RegisterModel
    {
        public AppUser AppUser { get; set; }

        public string Password { get; set; }
        public string PasswordRepeat { get; set; }
    }
}
