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
        [HttpGet("[controller]/{id}", Name = "GetTeacherById")]
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
        [HttpGet("[controller]/{GetAllTeachers}")]
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



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Post: AddTeacher
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [HttpPost("[controller]/{AddTeacher}")]
        public async Task<IActionResult> AddTeacher(Teacher teacher)
        {


            if (teacher == null)
            {
                return NotFound();
            }

            unitOfWork.Teacher.Add(teacher);

            var teachersList = new List<Teacher>();
            foreach (var teach in teachersList)
            {
                teachersList.Add(_mapper.Map<Teacher>(teach));
            }

            return Ok(teachersList);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Put: UpdateTeacher
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [HttpPut("[controller]/{UpdateTeacher}")]
        public async Task<IActionResult> UpdateTeacher(Teacher teacher)
        {
            unitOfWork.Teacher.Add(teacher);

            if (teacher == null)
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

        // Delete: DeleteTeacher
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [HttpDelete("[controller]/{DeleteTeacher}")]
        public async Task<IActionResult> DeleteTeacher(Teacher teacher)
        {
            unitOfWork.Teacher.Remove(teacher);

            if (teacher == null)
            {
                return NotFound();
            }

            return Ok("Delete Successful");
        }


    }
}
