using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using BookCatalog.Contracts;
using BookCatalog.Web.Models;

namespace BookCatalog.Web.Controllers
{
    public class BookController : Controller
    {
        public readonly IUnitOfWork unitOfWork;

        public BookController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoadData()
        {
            var draw = Request.Form.GetValues("draw").FirstOrDefault();
            var start = Request.Form.GetValues("start").FirstOrDefault();
            var length = Request.Form.GetValues("length").FirstOrDefault();
            var sortColumn = Request.Form.GetValues("columns[" + Request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
            var sortColumnDir = Request.Form.GetValues("order[0][dir]").FirstOrDefault();
            var searchValue = Request.Form.GetValues("search[value]").FirstOrDefault();

            //Paging Size (10,20,50,100)  
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;

            // Getting all Book data
            var bookData = unitOfWork.Books
                .Find(x => true, x => x.Authors)
                .Select(x => new BookViewModel {
                                    BookId = x.BookId,
                                    Name = x.Name,
                                    PublishDate = x.PublishDate,
                                    PageCount = x.PageCount,
                                    Rating = x.Rating,
                                    Authors = x.Authors.Select(f => f.FirstName + " " + f.LastName).ToArray()
                });

            //Sorting  
            //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
            //{
            //    bookData = bookData.OrderBy(x => x.Name); //.OrderBy(sortColumn + " " + sortColumnDir);
            //}

            //Search  
            if (!string.IsNullOrEmpty(searchValue))
            {
                bookData = bookData.Where(m => m.Name == searchValue
                || m.PageCount.ToString() == searchValue || m.Rating.ToString() == searchValue);
            }

            //total number of rows count   
            recordsTotal = bookData.Count();
            //Paging   
            var data = bookData.Skip(skip).Take(pageSize).ToList();
            //Returning Json Data  
            return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }

        [HttpGet]
        public ActionResult Edit(Guid? id)
        {
            var Book = unitOfWork.Books.Get(id);

                    return View(Book);
        }

        [HttpPost]
        public JsonResult DeleteBook(Guid? id)
        {
            if (id == null)
                    return Json(data: "Not Deleted", behavior: JsonRequestBehavior.AllowGet);
            unitOfWork.Books.Remove(id);
            unitOfWork.SaveChanges();
                    return Json(data: "Deleted", behavior: JsonRequestBehavior.AllowGet);
        }
    }
}