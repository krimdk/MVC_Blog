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

        [HttpPost]
        public ActionResult Edit(Post p)
        {
            p.Dato = DateTime.Now;
            postFac.Update(p);

            return View(postFac.Get(p.ID));
        }
    }
}