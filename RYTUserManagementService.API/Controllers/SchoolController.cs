using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RYTUserManagementService.Domain.RepoImplementations;
using RYTUserManagementService.Domain.RepoInterfaces;
using RYTUserManagementService.Dto;
using RYTUserManagementService.Models;



namespace RYTUserManagementService.API.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Components.Route("[controller]")]
    public class SchoolController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public SchoolController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }



        // <summary>
        // 
        // </summary>
        // <param name = "id" ></ param >
        // < returns ></ returns >

        //GET: School
       [ProducesResponseType(200)]
       [ProducesResponseType(400)]
       [ProducesResponseType(404)]
       [HttpGet("[controller]/{id}", Name = "GetSchoolById")]
        public async Task<IActionResult> GetSchoolById(int id)
        {
            var schools = unitOfWork.School.GetById(id);
            if (schools == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<School>(schools));

        }





        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: AllSchools
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [HttpGet("[controller]/{GetAllSchools}")]
        public async Task<IActionResult> GetAllSchools()
        {
            var schools = unitOfWork.School.GetAll();
            if (schools == null)
            {
                return NotFound();
            }

            var schoolsList = new List<CreateSchoolDto>();
            foreach (var school in schoolsList)
            {
                schoolsList.Add(_mapper.Map<CreateSchoolDto>(school));
            }

            return Ok(schoolsList);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Post: AddSchool
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [HttpPost("[controller]/{AddSchool}")]
        public async Task<IActionResult> AddSchool(CreateSchoolDto school)
        {


            if (school == null)
            {
                return NotFound();
            }

            unitOfWork.School.Add(school);

            var schoolsList = new List<CreateSchoolDto>();
            foreach (var sch in schoolsList)
            {
                schoolsList.Add(_mapper.Map<CreateSchoolDto>(sch));
            }

            return Ok(schoolsList);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Put: UpdateSchool
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [HttpPut("[controller]/{UpdateSchool}")]
        public async Task<IActionResult> UpdateSchool(CreateSchoolDto school)
        {
            unitOfWork.School.Add(school);

            if (school == null)
            {
                return NotFound();
            }

            return Ok("Update Successful");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Delete: DeleteSchool
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [HttpDelete("[controller]/{DeleteSchool}")]
        public async Task<IActionResult> DeleteSchool(CreateSchoolDto school)
        {
            unitOfWork.School.Remove(school);

            if (school == null)
            {
                return NotFound();
            }

            return Ok("Delete Successful");
        }

    }
}

