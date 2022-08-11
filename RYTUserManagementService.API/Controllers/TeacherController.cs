using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RYTUserManagementService.Domain.RepoImplementations;
using RYTUserManagementService.Domain.RepoInterfaces;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.API.Controllers
{
    public class TeacherController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public TeacherController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: Teacher
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [HttpGet("id", Name = "GetTeacherById")]
        public async Task<IActionResult> GetTeacherById(int id)
        {
            var teachers = unitOfWork.Teacher.GetById(id);
            if (teachers == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<Teacher>(teachers));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: AllTeachers
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [HttpGet]
        public async Task<IActionResult> GetAllTeachers()
        {
            var teachers = unitOfWork.Teacher.GetAll();
            if (teachers == null)
            {
                return NotFound();
            }

            var teachersList = new List<Teacher>();
            foreach (var teacher in teachersList)
            {
                teachersList.Add(_mapper.Map<Teacher>(teacher));
            }

            return Ok(teachersList);
        }




    }
}
