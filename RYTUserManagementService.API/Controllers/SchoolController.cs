using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RYTUserManagementService.Domain.RepoImplementations;
using RYTUserManagementService.Models;
using System.Web.Mvc;

namespace RYTUserManagementService.API.Controllers
{
    public class SchoolController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private UnitOfWork<School> unitOfWork = new UnitOfWork<School>();
        private readonly IMapper _mapper;

        public SchoolController(UnitOfWork<School> unitOfWork, IMapper mapper)
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
            var schools = unitOfWork.GeneralRepository.GetByID(id);
            if (schools == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<School>(students));
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
            var schools = unitOfWork.GeneralRepository.Get();
            if (schools == null)
            {
                return NotFound();
            }

            var schoolsList = new List<School>();
            foreach (var school in schoolsList)
            {
                schoolsList.Add(_mapper.Map<School>(school));
            }

            return Ok(schoolsList);
        }





        // GET: Game/Details/5
        public ActionResult Details(int? id)
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
        // GET: Game/Create
        public ActionResult Create()
        {
            return View();
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
