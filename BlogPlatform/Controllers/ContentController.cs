using BlogPlatform.Models;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class ContentController : Controller
    {
        private IRepository<Content> _contentRepo;
        public DateTime Now;
        
        

        public ContentController(IRepository<Content> contentRepo)
        {
            this._contentRepo = contentRepo;
            this.Now = DateTime.Now;
        }
        public IActionResult Index(string? message)
        {
            if (!String.IsNullOrEmpty(message))
            {
                ViewBag.Result = message;
            }

            return View(_contentRepo.GetAll());
        }

        public IActionResult AddContent()
        {
            DateTime Now = DateTime.Now;
            ViewBag.Categories = _contentRepo.GetAllCategories(); 
            return View(new Content());
        }

        [HttpPost]
        public IActionResult AddContent(Content newContent)
        {
            newContent.Now = DateTime.Now;
            _contentRepo.Create(newContent);
            //newContent.Now = this.Now;
            //inputDate.Value = Now;
            return RedirectToAction("Index");
        }

        public IActionResult DeleteContent(int id)
        {
            var contentToDelete = _contentRepo.GetByID(id);
            _contentRepo.Delete(contentToDelete);
            return RedirectToAction("Index");
        }

        public ViewResult Details(int id)
        {
            return View(_contentRepo.GetByID(id));
        }

        public ViewResult Update(int id)
        {
            DateTime Now = DateTime.Now; 
            ViewBag.Categories = _contentRepo.GetAllCategories();
            var content = _contentRepo.GetByID(id);
            return View(content);
        }

        [HttpPost]
        public ActionResult Update(Content content)
        {
            _contentRepo.Update(content);
            return RedirectToAction("Index");
        }
    }
}
