using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RYTUserManagementService.Domain.RepoImplementations;
using System.Web.Mvc;

namespace RYTUserManagementService.API.Controllers
{
    public class UserController : BaseApiController
    {
        private UnitOfWork<IdentityUser> unitOfWork = new UnitOfWork<IdentityUser>();
        private readonly IMapper _mapper;

        public UserController(UnitOfWork<IdentityUser> unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: User
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpGet("id", Name = "GetUserById")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var users = unitOfWork.GeneralRepository.GetByID(id);
            if (users == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IdentityUser>(users));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET: AllUsers
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = unitOfWork.GeneralRepository.Get();
            if (users == null)
            {
                return NotFound();
            }

            var usersList = new List<IdentityUser>();
            foreach (var user in usersList)
            {
                usersList.Add(_mapper.Map<IdentityUser>(user));
            }

            return Ok(usersList);
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
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
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
