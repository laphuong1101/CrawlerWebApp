using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CrawlerWebApp.Controllers
{
    public class PostsController : Controller
    {
        private CrawlerDatabaseEntities db;

        public PostsController()
        {
            db = new CrawlerDatabaseEntities();
        }
        // GET: Posts
        public ActionResult Index()
        {
            return View(db.Posts.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Post post = db.Posts.Find(id);
            if (post == null)
            {
                return HttpNotFound();
            }

           
            return View(post);
        }
    }
}