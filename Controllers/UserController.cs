using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WxDevChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public User Get()
        {
            return new User {Name = "Mouna Neelakanta", Token = "67b75a66-1654-4332-ba4f-85b095ef235a"};
        }
    }
}