using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacaoComCodeFirst.Models;

namespace AplicacaoComCodeFirst.Controllers
{
    public class TagsController : Controller
    {
        private BlogContext db = new BlogContext();

        //
        // GET: /Tags/

        public ActionResult Index()
        {
            return View(db.Tags.ToList());
        }

        //
        // GET: /Tags/Details/5

        public ActionResult Details(int id = 0)
        {
            Tags tags = db.Tags.Find(id);
            if (tags == null)
            {
                return HttpNotFound();
            }
            return View(tags);
        }

        //
        // GET: /Tags/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tags/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Tags tags)
        {
            if (ModelState.IsValid)
            {
                db.Tags.Add(tags);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tags);
        }

        //
        // GET: /Tags/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Tags tags = db.Tags.Find(id);
            if (tags == null)
            {
                return HttpNotFound();
            }
            return View(tags);
        }

        //
        // POST: /Tags/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tags tags)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tags).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tags);
        }

        //
        // GET: /Tags/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Tags tags = db.Tags.Find(id);
            if (tags == null)
            {
                return HttpNotFound();
            }
            return View(tags);
        }

        //
        // POST: /Tags/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tags tags = db.Tags.Find(id);
            db.Tags.Remove(tags);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}