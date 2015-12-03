using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoBlog.Factories;
using RepoBlog.Models;
using RepoBlog.Models.BaseModels;

namespace MVC_Blog.Controllers
{
    public class BlogController : Controller
    {
        PostFac postFac = new PostFac();
        // GET: Blog
        public ActionResult Index()
        {
            return View(postFac.GetIndexData());
        }

        public ActionResult Edit(int id)
        {
            return View(postFac.Get(id));
        }
        public ActionResult Delete(int id)
        {
            postFac.Delete(id);
            return View("Index", postFac.GetIndexData());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(Post p)
        {
            p.Dato = DateTime.Now;

            if (ModelState.IsValid)
            {
                postFac.Update(p);
            }
            
            return View(postFac.Get(p.ID));
        }

        public ActionResult Creat()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Creat(Post p)
        {
            p.Dato = DateTime.Now;

            if (ModelState.IsValid)
            {
                postFac.Insert(p);

                ViewBag.msg = "Posten er oprettet";
            }
            else
            {
                ViewBag.msg = "Der opstod en fejl, posten er ikke oprettet";
            }
            
            return View();
        }
    }
}