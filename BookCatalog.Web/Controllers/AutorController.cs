using BookCatalog.Contracts;
using BookCatalog.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookCatalog.Web.Controllers
{
    public class AuthorController : Controller
    {
        public readonly IUnitOfWork unitOfWork;

        public AuthorController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public ActionResult EditAuthor(Guid? id)
        {
            var authorData = unitOfWork.Authors.Get(id);

            return View(authorData);
        }

        [HttpGet]
        public JsonResult GetAllAuthors()
        {
            var authors = unitOfWork.Authors.Find(a => true).Select(a => new AuthorViewModel { AuthorId = a.AuthorId, FirstName = a.FirstName, LastName = a.LastName});

            return Json(new { authors = authors }, behavior: JsonRequestBehavior.AllowGet);
        }

        /*
        [HttpPost]
        public ActionResult EditAthor(Author author)
        {


            return 
        }*/
    }
}