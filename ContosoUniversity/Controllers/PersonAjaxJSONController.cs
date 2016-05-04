using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;
using ContosoUniversity.ViewModels;

namespace ContosoUniversity.Controllers
{
    [HandleError]
    public class PersonAjaxJSONController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: PersonAjaxJSON
        public ActionResult Index()
        {
            return View(db.PersonAjaxJSONs.ToList());
        }

        [HttpPost]
        public ActionResult Save(PersonAjaxJSON ajaxJSON)
        {
            string msg = string.Format("Created user {0} in the system.", ajaxJSON.Name);
            return Json(new PersonAjaxJSONViewModel { Message = msg });
        }



        // GET: PersonAjaxJSON/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonAjaxJSON personAjaxJSON = db.PersonAjaxJSONs.Find(id);
            if (personAjaxJSON == null)
            {
                return HttpNotFound();
            }
            return View(personAjaxJSON);
        }

        // GET: PersonAjaxJSON/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonAjaxJSON/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Age")] PersonAjaxJSON personAjaxJSON)
        {
            if (ModelState.IsValid)
            {
                db.PersonAjaxJSONs.Add(personAjaxJSON);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personAjaxJSON);
        }

        // GET: PersonAjaxJSON/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonAjaxJSON personAjaxJSON = db.PersonAjaxJSONs.Find(id);
            if (personAjaxJSON == null)
            {
                return HttpNotFound();
            }
            return View(personAjaxJSON);
        }

        // POST: PersonAjaxJSON/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Age")] PersonAjaxJSON personAjaxJSON)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personAjaxJSON).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personAjaxJSON);
        }

        // GET: PersonAjaxJSON/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonAjaxJSON personAjaxJSON = db.PersonAjaxJSONs.Find(id);
            if (personAjaxJSON == null)
            {
                return HttpNotFound();
            }
            return View(personAjaxJSON);
        }

        // POST: PersonAjaxJSON/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonAjaxJSON personAjaxJSON = db.PersonAjaxJSONs.Find(id);
            db.PersonAjaxJSONs.Remove(personAjaxJSON);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
