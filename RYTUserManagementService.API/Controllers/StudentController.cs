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
    public class StudentController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public StudentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }
     


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: Student
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpGet("id", Name = "GetStudentById")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var students = unitOfWork.Student.GetById(id);
            if (students == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CreateStudentDTO>(students));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: AllStudents
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetAllSchools()
        {
            var students = unitOfWork.Student.GetAll();
            if (students == null)
            {
                return NotFound();
            }

            var studentsList = new List<CreateStudentDTO>();
            foreach (var student in studentsList)
            {
                studentsList.Add(_mapper.Map<CreateStudentDTO>(student));
            }

            return Ok(studentsList);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Post: AddStudent
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        public async Task<IActionResult> AddStudent(CreateStudentDTO student)
        {


            if (student == null)
            {
                return NotFound();
            }

            unitOfWork.Student.Add(student);

            var studentList = new List<CreateStudentDTO>();
            foreach (var stud in studentList)
            {
                studentList.Add(_mapper.Map<CreateStudentDTO>(stud));
            }

            return Ok(studentList);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Put: UpdateStudent
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpPut]
        public async Task<IActionResult> UpdateStudent(CreateStudentDTO student)
        {
            unitOfWork.Student.Add(student);

            if (student == null)
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

        // Delete: DeleteStudent
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpDelete]
        public async Task<IActionResult> DeleteStudent(CreateStudentDTO student)
        {
            unitOfWork.Student.Remove(student);

            if (student == null)
            {
                return NotFound();
            }

            return Ok("Delete Successfull");
        }
    }
}
