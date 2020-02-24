<<<<<<< HEAD
using Api.RegistroUsuario;
using Api.RegistroUsuariode;
using API.Infraestructure;
using Api.Application;

namespace Api.Application
{
    class UserService : BaseService, IUserService
    {
        private readonly IUserContext _context;
        public UserService(IUserContext context) : base(context)
        {
            _context = context;
        }

        public UserRegistered Register(UserRegistration userRegistration)
        {
            var user = User.Create(userRegistration);
            _context.User.Add(user);
            _context.SaveChanges();
            return UserRegistered.Create(user);
=======
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Api.Dominio;
using Api.RegistroUsuariode;

namespace Api.ControladorUsuario
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        [HttpPost]
        public IActionResult Post([FromBody] UserRegistration userRegistration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            UserRegistered userRegistered = _userService.Register(userRegistration);
            // TODO: return Created
            return Ok(userRegistered);
>>>>>>> 61e19685840607a8c7127871aa8380010e25b183
        }
    }
}