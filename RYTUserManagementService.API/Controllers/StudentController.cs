using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RYTUserManagementService.Domain.RepoInterfaces;
using RYTUserManagementService.Dto;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.API.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Components.Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public StudentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            _mapper = mapper;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("[controller]/{id}", Name = "GetStudentById")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var school = _unitOfWork.School.GetById(id);
            if (school == null)
                return NotFound();

            return Ok(_mapper.Map<Student>(school));
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
        [HttpGet("[controller]/{GetAllStudents}")]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = _unitOfWork.Student.GetAll();
            if (students == null)
            {
                return NotFound();
            }

            var studentsList = new List<Student>();
            foreach (var student in studentsList)
            {
                studentsList.Add(_mapper.Map<Student>(student));
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
        [HttpPost("[controller]/{AddStudent}")]
        public async Task<IActionResult> AddStudent(CreateStudentDto student)
        {


            if (student == null)
            {
                return NotFound();
            }

            _unitOfWork.Student.Add(student);

            var studentsList = new List<Student>();
            foreach (var stud in studentsList)
            {
                studentsList.Add(_mapper.Map<Student>(stud));
            }

            return Ok(studentsList);
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
        [HttpPut("[controller]/{UpdateStudent}")]
        public async Task<IActionResult> UpdateStudent(CreateStudentDto student)
        {

            if (student == null)
            {
                return NotFound();
            }

            _unitOfWork.Student.Add(student);
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
        [HttpDelete("[controller]/{DeleteStudent}")]
        public async Task<IActionResult> DeleteSchool(CreateStudentDto student)
        {
            _unitOfWork.Student.Remove(student);

            if (student == null)
            {
                return NotFound();
            }

            return Ok("Delete Successful");

        }
    }
}
