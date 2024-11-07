using SocialMedia.Models;

namespace SocialMedia.ViewModels
{
    public class UsersIndexViewModel
    {
        public string Search { get; set; }
        public List<ApplicationUser> Result { get; set; } = new List<ApplicationUser>();
    }
}
