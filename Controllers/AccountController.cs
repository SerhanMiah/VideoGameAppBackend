using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using VideoGameAppBackend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using VideoGameAppBackend.Models.User;

namespace AnimeShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;  // Add this line
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;  // And this line
            _configuration = configuration;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser 
                { 
                    UserName = model.Email, 
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    // add the rest of your fields here
                };

                // Add a check here to debug
                if(user.UserName == null || user.Email == null)
                {
                    // log some error message here
                    return BadRequest(new { message = "UserName or Email cannot be null."});
                }

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return Ok(new { message = "User successfully registered and signed in."});
                }
                AddErrors(result);
                return BadRequest(ModelState);  // Return ModelState that contains error messages
            }
            // If we got this far, something failed, return BadRequest
            return BadRequest(new { message = "Invalid registration details."});
        }



        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] Login userModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (string.IsNullOrEmpty(userModel.Email))
                {
                    return BadRequest("Email is required.");
                }

                var user = await _userManager.FindByEmailAsync(userModel.Email);
                if (user != null &&
                    await _userManager.CheckPasswordAsync(user, userModel.Password))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.Id),
                        new Claim(ClaimTypes.Name, user.UserName),
                    };

                    var token = GenerateJwtToken(claims);

                    return Ok(new { Token = token });
                }
                else
                {
                    return BadRequest("Invalid UserName or Password");
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine(ex.Message);

                // Return a generic error message
                return BadRequest("An error occurred while logging in.");
            }
        }

        
        [Authorize]
        [HttpGet]
        [Route("profile")]
        public async Task<IActionResult> GetProfile()
        {
            try
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized();
                }

                var user = await _userManager.FindByIdAsync(userId);
                if (user == null)
                {
                    return NotFound("User not found.");
                }

                var profile = new UserViewModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Address = user.Address,
                    City = user.City,
                    State = user.State,
                    PostalCode = user.PostalCode,
                    Country = user.Country
                };

                return Ok(profile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest("An error occurred while getting the profile.");
            }
        }


        private string GenerateJwtToken(List<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Issuer"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(7),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

    }
}