using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RYTUserManagementService.Domain.RepoInterfaces;
using RYTUserManagementService.Dto;

namespace RYTUserManagementService.API.Controllers
{
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo _studentRepo;
        private readonly IMapper _mapper;

        public StudentController(IStudentRepo studentsRepo, IMapper mapper)
        {
            _studentRepo = studentsRepo;
            _mapper = mapper;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [HttpGet("id", Name = "GetStudentById")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var checkId = await _studentRepo.GetStudentById(id);
            if(checkId == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<StudentsDto>(checkId));
            
        }
    }
}
