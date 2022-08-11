using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RYTUserManagementService.Domain.RepoImplementations;
using RYTUserManagementService.Domain.RepoInterfaces;

using RYTUserManagementService.Dto;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.API.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Components.Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IdentityUser identityUser;
        private readonly IMapper _mapper;

        public UserController(IUnitOfWork unitOfWork, IMapper mapper, IdentityUser identityUser)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
            this.identityUser = identityUser;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: AllUsers
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpGet("{GetAllUsers}")]
        public async Task<IActionResult> GetAllUsers()
        {

            var usersList = new List<IdentityUser>();

            if (usersList == null)
            {
                return NotFound();
            }
            foreach (var user in usersList)
            {
                usersList.Add(_mapper.Map<IdentityUser>(user));
            }

            return Ok(usersList); 
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Post: AddUser
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpPost("[controller]/{AddUser}")]
        public async Task<IActionResult> AddUser(IdentityUser user)
        {
            if (user == null)
            {
                return NotFound();
            }
            var usersList = new List<IdentityUser>();
            foreach (var use in usersList)
            {
                usersList.Add(_mapper.Map<IdentityUser>(use));
            }

            return Ok(usersList);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Put: UpdateUser
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpPut("[controller]/{UpdateUser}")]
        public async Task<IActionResult> UpdateUser(IdentityUser user)
        {
            var userPresent = _mapper.Map<IdentityUser>(user);
            if (user == null)
            {
                return NotFound();
            }
            else if (user == userPresent)
            {
                return Ok();
            }

            
            return Ok("Update Successful");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Delete: DeleteUser
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpDelete("[controller]/{DeleteUser}")]
        public async Task<IActionResult> DeleteUser(IdentityUser user)
        {
            

            if (user == null)
            {
                return NotFound();
            }

            return Ok("Delete Successful");
        }




    }
}
