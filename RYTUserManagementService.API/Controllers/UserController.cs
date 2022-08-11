//using AutoMapper;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using RYTUserManagementService.Domain.RepoImplementations;
//using RYTUserManagementService.Domain.RepoInterfaces;
//using System.Web.Mvc;

//namespace RYTUserManagementService.API.Controllers
//{
//    public class UserController : Microsoft.AspNetCore.Mvc.ControllerBase
//    {
//        private readonly IUnitOfWork unitOfWork;
//        private readonly IdentityUser identityUser;
//        private readonly IMapper _mapper;

//        public UserController(IUnitOfWork unitOfWork, IMapper mapper, IdentityUser identityUser)
//        {
//            this.unitOfWork = unitOfWork;
//            _mapper = mapper;
//            this.identityUser = identityUser;
//        }


        
     

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="id"></param>
//        /// <returns></returns>

//        // GET: AllUsers
//        [ProducesResponseType(200)]
//        [ProducesResponseType(400)]
//        [ProducesResponseType(404)]
//        [Microsoft.AspNetCore.Mvc.HttpGet]
//        public async Task<IActionResult> GetAllUsers()
//        {
           
//            var usersList = new List<IdentityUser>();

//            if (usersList == null)
//            {
//                return NotFound();
//            }
//            foreach (var user in usersList)
//            {
//                usersList.Add(_mapper.Map<IdentityUser>(user));
//            }

//            return Ok(usersList);
//        }





//    }
//}
