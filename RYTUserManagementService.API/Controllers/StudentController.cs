using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RYTUserManagementService.Domain.RepoInterfaces;
using RYTUserManagementService.Models;

namespace RYTUserManagementService.API.Controllers
{
    [ApiController]
    [Route("[controller]/api/v1")]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<StudentController> _logger;


        public StudentController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<StudentController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetStudentById(string id)
        {
            try
            {
                var student = await _unitOfWork.Students.Get(q => q.Id == id, new List<string>{"Students"});
                //var result = _mapper.Map<StudentsDto>(student);
                return Ok(student);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something went wrong in the {nameof(GetStudentById)}");
                return StatusCode(500, "Internal Server Error. Please try Again Later.");
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: AllStudents
        [HttpGet("GetAllStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllStudents()
        {
            try
            {
                var students = await _unitOfWork.Students.GetAll();
                //var results = _mapper.Map<IList<StudentsDto>>(students);
                return Ok(students);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something went wrong in the {nameof(GetAllStudents)}");
                return StatusCode(500, "Internal Server Error. Please try Again Later.");
            }
            
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Post: CreateStudent
        [Authorize]
        [HttpPost("CreateStudent")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateStudent([FromBody] Student student)
        {

            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid Post attempt in {nameof(CreateStudent)}");
                return BadRequest(ModelState);
            }

            try
            {
                //var student = _mapper.Map<Student>(studentDto);
                await _unitOfWork.Students.Insert(student);
                await _unitOfWork.Save();

                return CreatedAtRoute("GetStudent", new {id = student.Id}, student);

            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something went wrong in the {nameof(CreateStudent)}");
                return StatusCode(500, "Internal Server Error. Please try Again Later.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Put: UpdateStudent
        [Authorize]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut("UpdateStudent")]
        public async Task<IActionResult> UpdateStudent(string id, [FromBody] Student student)
        {

            if (!ModelState.IsValid || id == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateStudent)}");
                return BadRequest(ModelState);
            }

            try
            {
                var updatestud = await _unitOfWork.Students.Get(q => q.Id == id);
                if (updatestud == null)
                {
                    _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateStudent)}");
                    return BadRequest("Submitted Data is Invalid");
                }

                //_mapper.Map(studentDto, student);
                _unitOfWork.Students.Update(updatestud);
                await _unitOfWork.Save();

                return NoContent();
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something went wrong in the {nameof(UpdateStudent)}");
                return StatusCode(500, "Internal Server Error. Please try Again Later.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // Delete: DeleteStudent
        [Authorize]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete("DeleteStudent")]
        public async Task<IActionResult> DeleteStudent(string id)
        {
            if (id == null)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteStudent)}");
                return BadRequest(ModelState);
            }

            try
            {
                var student = await _unitOfWork.Students.Get(q => q.Id == id);
                if (student == null)
                {
                    _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteStudent)}");
                    return BadRequest("Submitted Data is Invalid");
                }

                //var newId = Convert.ToInt32(student.Id);

                await _unitOfWork.Students.Delete(student.Id);
                await _unitOfWork.Save();

                return NoContent();
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something went wrong in the {nameof(DeleteStudent)}");
                return StatusCode(500, "Internal Server Error. Please try Again Later.");
            }

        }
    }
}
