using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace OAuth_API.Controllers
{
    [Tags(" Log in with OAuth 2.0")] // Name of the Controller that will be displayed on the Swagger Document
    [ApiController]
    //[ApiExplorerSettings(GroupName = "main")] // Document where the Controller belongs to (Remove/Comment to make Controller appear in all Documents)
    [Route("[controller]/[action]")]
    public class LoginController : ControllerBase {
        [SwaggerResponse(200, ContentTypes = new string[] { "User session token" })] // Custom return type to avoid Swagger to display the object attributes.
        [SwaggerOperation(Summary = "Log in", Description = "<strong>Log in and get a Token.</strong><br>"
                + "<br>When you get your <i>Bearer</i> Token, copy it, click the [Authotize] button on the start of the page or on the open lock icon at the upper right side of every endpoint and then paste the token."
                + "<br>The tokens are valid for 15 minutes, after that time you'll need to get another one."
        )]
        [ActionName("LogIn")] // Name of the Endpoint that will be displayed on the Swagger Document
        [HttpGet]
        public IActionResult Login([BindRequired] string UserName, [BindRequired, DataType(DataType.Password)] string Password)
        {
            IActionResult result = null;

            try
            {
                if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
                    return BadRequest("User or password were not specified.");

                for (int ii = 0; ii < Users.Get().ToList().Count; ii++)
                { // It searches on the user list
                    if (Users.Get().ToList()[ii].ClientId.Equals(UserName) && Users.Get().ToList()[ii].ClientSecrets.Equals(Password.GetHashCode()))
                    { // If it exists, it creates a token
                        var SecretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Put13245!.Here12345!.Your12345!.Key12345!")); // Key (must be above 256 bits)
                        var SigninCredentials = new SigningCredentials(SecretKey, SecurityAlgorithms.HmacSha256);

                        Claim Claims = new Claim("User", "user"); // Default permissions
                        // In case of being a Admin, it grants those permissions
                        if (Users.Get().ToList()[ii].IsAdmin == true)
                            Claims = new Claim("Admin", "admin");

                        var jwtSecurityToken = new JwtSecurityToken(
                            issuer: "This",
                            audience: "Client",
                            claims: new List<Claim>() { Claims },
                            expires: DateTime.Now.AddMinutes(10), // Expiration time (default is 5 minutes plus an additional 10 minutes that I added)
                            signingCredentials: SigninCredentials
                        );

                        result = Ok(new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken));
                    }
                }
            }
            catch
            {
                return BadRequest("An error occurred while creating the token.");
            }

            if (result == null)
                return BadRequest("Incorrect user or password.");

            return result;
        }
    }
}
