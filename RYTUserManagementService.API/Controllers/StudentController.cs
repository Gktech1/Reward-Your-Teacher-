using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RYTUserManagementService.Domain.RepoImplementations;
using RYTUserManagementService.Models;
using System.Web.Mvc;

namespace RYTUserManagementService.API.Controllers
{
    public class StudentController : BaseApiController
    {
        private UnitOfWork<Student> unitOfWork = new UnitOfWork<Student>();
        private readonly IMapper _mapper;

        public StudentController(UnitOfWork<Student> unitOfWork, IMapper mapper)
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
            var students = unitOfWork.GeneralRepository.GetByID(id);
            if (students == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<Student>(students));
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
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = unitOfWork.GeneralRepository.Get();
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

        // GET: AStudentBySchool
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetStudentsBySchoolID(int studentId, int schoolId )
        {
            School school = new School();
            Student student = new Student();
            if (school.Id.Equals(schoolId))
            {
                var students = unitOfWork.GeneralRepository.Get().Where(x => schoolId == school.Id &&  studentId == student.Id.FirstOrDefault();
            }

            
            if (students == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<Student>(students));
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
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetAllStudentsBySchoolId(int id)
        {
            var students = unitOfWork.GeneralRepository.Get().Where(x => x.Student.id == x.Id);
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

        // POST: Student
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStudent(Student student)
        {
            
        }


        // POST: Game/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Game game)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.GameRepository.Insert(game);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(game);
        }
        // GET: Game/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = unitOfWork.GameRepository.GetByID(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }
        // POST: Game/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Game game)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.GameRepository.Update(game);
                unitOfWork.Save();
                return RedirectToAction("Index");
            }
            return View(game);
        }
        // GET: Game/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Game game = unitOfWork.GameRepository.GetByID(id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }
        // POST: Game/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Game game = unitOfWork.GameRepository.GetByID(id);
            unitOfWork.GameRepository.Delete(id);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
