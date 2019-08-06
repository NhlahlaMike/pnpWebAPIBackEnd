using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using pnpWebAPIBackEnd.Models;

namespace pnpWebAPIBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private UserManager<ApplicationUser> _userManager;
        private readonly ApplicationUser _context;
        public UserProfileController(ApplicationUser context, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        [HttpGet]
        [Authorize]
        //GET : /api/UserProfile
        public async Task<Object> GetUserProfile()
        {
            string userId = User.Claims.First(c => c.Type == "UserID").Value;
            var user = await _userManager.FindByIdAsync(userId);
            return new
            {
                user.FirstName,
                user.Email,
                user.UserName
            };
        }

        /*
        [HttpGet]
        [Authorize]
        //GET : /api/UserProfile
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetPaymentDetails()
        {

            return await _context.ApplicationUser.ToListAsync();
        }*/
    }

}