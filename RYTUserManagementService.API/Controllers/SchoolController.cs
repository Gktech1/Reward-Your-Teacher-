using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RYTUserManagementService.Domain.RepoImplementations;
using RYTUserManagementService.Domain.RepoInterfaces;
using RYTUserManagementService.Dto;
using RYTUserManagementService.Models;
using System.Web.Mvc;

namespace RYTUserManagementService.API.Controllers
{
    public class SchoolController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public SchoolController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: School
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpGet("id", Name = "GetSchoolById")]
        public async Task<IActionResult> GetSchoolById(int id)
        {
            var schools = unitOfWork.School.GetById(id);
            if (schools == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<SchoolDTO>(schools));
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
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetAllSchools()
        {
            var schools = unitOfWork.School.GetAll();
            if (schools == null)
            {
                return NotFound();
            }

            var schoolsList = new List<SchoolDTO>();
            foreach (var school in schoolsList)
            {
                schoolsList.Add(_mapper.Map<SchoolDTO>(school));
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
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task<IActionResult> AddSchool(SchoolDTO school)
        {

            
            if (school == null)
            {
                return NotFound();
            }
            
            unitOfWork.School.Add(school);

            var schoolsList = new List<SchoolDTO>();
            foreach (var sch in schoolsList)
            {
                schoolsList.Add(_mapper.Map<SchoolDTO>(sch));
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
        [Microsoft.AspNetCore.Mvc.HttpPut]
        public async Task<IActionResult> UpdateSchool(SchoolDTO school)
        {
            unitOfWork.School.Add(school);

            if (school == null)
            {
                return NotFound();
            }

            return Ok("Update Successfull");
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
        [Microsoft.AspNetCore.Mvc.HttpDelete]
        public async Task<IActionResult> DeleteSchool(SchoolDTO school)
        {
            unitOfWork.School.Remove(school);

            if (school == null)
            {
                return NotFound();
            }

            return Ok("Delete Successfull");
        }

    }
}
