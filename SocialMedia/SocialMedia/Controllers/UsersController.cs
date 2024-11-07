using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Data;
using SocialMedia.ViewModels;

namespace SocialMedia.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;

        public UsersController(ApplicationDbContext dbContext)
        {
               _dbcontext = dbContext;  
        }

        public async Task<IActionResult> Index(UsersIndexViewModel viewModel)
        {
            if (viewModel.Search != null)
            { 
                var users = await _dbcontext.Users.Where(u => u.Name.Contains(viewModel.Search)).ToListAsync();
               
                viewModel.Result = users;
            }
         
            
           
            return View(viewModel);
        }
    }
}
