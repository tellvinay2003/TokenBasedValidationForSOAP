using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ODLSecirutyService.Models;

namespace ODLSecirutyService.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;

        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet]
        public IActionResult Login(string userName, string pass)
        {
            UserModel login = new UserModel();
            login.UserName = userName;
            login.Password = pass;

            IActionResult response = Unauthorized();

            var user = AuthenticateUSer(login);
            if (user != null)
            {
                var strToken = GenerateJwt(user);
                response = Ok(new { token = strToken });
            }

            return response;
        }

        [Authorize]
        [HttpPost("Post")]
        public string Post()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            IList<Claim> claims = identity.Claims.ToList();

            var userName = claims[0].Value;
            return "Welcome to : " + userName;
        }


        /// <summary>
        /// For calling svc web service
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("GetMappingsValue")]
        public ActionResult<IEnumerable<string>> Get()
        {
            string authDetails = HttpContext.Request.Headers["Authorization"].ToString();
            IEnumerable<string> response = new List<string>();
            MappingService.MappingServiceClient client = new MappingService.MappingServiceClient();
            using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
            {
                MessageHeader header = MessageHeader.CreateHeader("Token",
                                                                    "http://Microsoft.WCF.Documentation",
                                                                    authDetails);
                OperationContext.Current.OutgoingMessageHeaders.Add(header);

                response = client.GetMappingDetailsAsync().Result;
            }

            return Ok(response);
        }


        /// <summary>
        /// For calling svc web service
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("GetSearchResult")]
        public ActionResult<IEnumerable<SearchInfoData>> GetSearchResult()
        {
            string authDetails = HttpContext.Request.Headers["Authorization"].ToString();
            IEnumerable<string> response = new List<string>();
            MappingService.MappingServiceClient client = new MappingService.MappingServiceClient();
            using (OperationContextScope scope = new OperationContextScope(client.InnerChannel))
            {
                MessageHeader header = MessageHeader.CreateHeader("Token",
                                                                    "http://Microsoft.WCF.Documentation",
                                                                    authDetails);
                OperationContext.Current.OutgoingMessageHeaders.Add(header);

                response = client.GetMappingDetailsAsync().Result;
            }

            return Ok(response);
        }



        /// <summary>
        /// For calling asmx Web service
        /// </summary>
        /// <returns></returns>
        // [Authorize]
        [HttpGet("GetAccessToWb")]
        public ActionResult<string> GetAccessToWb()
        {
            string authDetails = HttpContext.Request.Headers["Authorization"].ToString();
            
            AsmxUtilityWebService.SecuredToken securedToken = new AsmxUtilityWebService.SecuredToken();
            securedToken.AuthenticationToken = authDetails;
            AsmxUtilityWebService.AuthTokenSoapClient client = new AsmxUtilityWebService.AuthTokenSoapClient(AsmxUtilityWebService.AuthTokenSoapClient.EndpointConfiguration.AuthTokenSoap);
            var response = client.CheckAccessAsync(securedToken);
            return Ok(response.Result.CheckAccessResult);
        }



        [Authorize]
        [HttpGet("GetAccessToUtility")]
        public ActionResult<string> GetAccessToUtility()
        {
            string authDetails = HttpContext.Request.Headers["Authorization"].ToString();

            UtilityService.SecuredToken securedToken = new UtilityService.SecuredToken();
            securedToken.AuthenticationToken = authDetails;
            UtilityService.UtilityServiceSoapClient client = new UtilityService.UtilityServiceSoapClient(UtilityService.UtilityServiceSoapClient.EndpointConfiguration.UtilityServiceSoap);
            var response = client.HelloWorldAsync(securedToken);
            return Ok(response.Result.HelloWorldResult);
        }


        private string GenerateJwt(UserModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
              new Claim(JwtRegisteredClaimNames.Sub, userInfo.UserName),
              new Claim(JwtRegisteredClaimNames.Email, userInfo.EmailAddress),
              new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            // TODO: Toekn renew 

            var token = new JwtSecurityToken("https://localhost:44313/", // issuer: _config["Jwt: Issuer"],
                                             "https://localhost:44313/", // audience: _config["Jwt:Issuer"],
                                              claims,
                                               expires: DateTime.Now.AddMinutes(120),
                                               signingCredentials: credentials);

            var encodedTokn = new JwtSecurityTokenHandler().WriteToken(token);
            return encodedTokn;
        }

        private UserModel AuthenticateUSer(UserModel login)
        {
            UserModel user = null;
            // For now it's ststic details...in future this will be verified from DB call
            if (login.UserName == "Vinay" && login.Password == "pwd")
            {
                user = new UserModel { UserName = "Vinay", Password = "pwd", EmailAddress = "vinay.pandey@odl.com" };
            }

            return user;
        }



        public class SearchInfoData
        {
           

        }
    }
}