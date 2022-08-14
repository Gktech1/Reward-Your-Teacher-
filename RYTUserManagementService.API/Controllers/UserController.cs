using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RYTUserManagementService.Core.ServiceInterfaces;
using RYTUserManagementService.Dto;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.API.Controllers
{
    [ApiController]
    [Route("[controller]/api/v1")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<ApiUser> _userManager;
        private readonly SignInManager<ApiUser> _signInManager;
        private readonly ILogger<UserController> _logger;
        private readonly IMapper _mapper;
        private readonly IAuthManager _authManager;

        public UserController(
                UserManager<ApiUser> userManager,
                SignInManager<ApiUser> signInManager,
                ILogger<UserController> logger,
                IMapper mapper,
                IAuthManager authManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _mapper = mapper;
            _authManager = authManager;
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Post: AddUser
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]


        [HttpPost("RegisterUser")]
        public async Task<IActionResult> Register([FromBody] UserDto userDto)
        {
            _logger.LogInformation($"Registration attempt for {userDto.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var user = _mapper.Map<ApiUser>(userDto);
                user.UserName = userDto.Email;
                var result = await _userManager.CreateAsync(user, userDto.Password);

                if (!result.Succeeded)
                {
                    return BadRequest($"User Registration Attempt Failed");
                }

                await _userManager.AddToRolesAsync(user, userDto.Roles);

                return Accepted();
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something Went Wrong in the {nameof(Register)}");
                return Problem($"Something Went wrong in the {nameof(Register)}", statusCode: 500);
            }


        }




        // <summary>
        // 
        // </summary>
        // <param name = "id" ></ param >
        // < returns ></ returns >

       // Post: LoginUser
       [ProducesResponseType(StatusCodes.Status200OK)]
       [HttpPost("LoginUser")]
        public async Task<IActionResult> Login([FromBody] LoginUserDto userDto)
        {
            _logger.LogInformation($"Login attempt for {userDto.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

                if (!await _authManager.ValidateUser(userDto))
                {
                    return Unauthorized();
                }

                return Accepted(new { Token = await _authManager.CreateToken() });
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something Went Wrong in the {nameof(Login)}");
                return Problem($"Something Went wrong in the {nameof(Login)}", statusCode: 500);
            }


        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: AllUsers
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {


            return Ok();
        }



        
        /*/// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Put: UpdateUser
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Microsoft.AspNetCore.Mvc.HttpPut("[controller]/{UpdateUser}")]
        public async Task<IActionResult> UpdateUser()
        {



            return Ok("Update Successful");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Delete: DeleteUser
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Microsoft.AspNetCore.Mvc.HttpDelete("[controller]/{DeleteUser}")]
        public async Task<IActionResult> DeleteUser(string id)
        {




            return Ok("Delete Successful");
        }*/
        




    }
}
