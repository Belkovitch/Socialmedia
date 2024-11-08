using SocialMedia.Models;

namespace SocialMedia.ViewModels
{
    public class UsersShowUserViewModel
    {
        public ApplicationUser User { get; set; }
        public List<Broadcast> Broadcasts { get; set; }
    }
}
