using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Simple_Ecommerce_Proj.Models;

namespace Simple_Ecommerce_Proj.Controllers
{
    public class NhaCCsController : Controller
    {
        private fShopDB db = new fShopDB();

        // GET: NhaCCs
        public ActionResult Index()
        {
            return View(db.Nha_CC.ToList());
        }

        // GET: NhaCCs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nha_CC nha_CC = db.Nha_CC.Find(id);
            if (nha_CC == null)
            {
                return HttpNotFound();
            }
            return View(nha_CC);
        }

        // GET: NhaCCs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhaCCs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNCC,TenNCC,DiaChi,DienThoai,Email")] Nha_CC nha_CC)
        {
            if (ModelState.IsValid)
            {
                db.Nha_CC.Add(nha_CC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nha_CC);
        }

        // GET: NhaCCs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nha_CC nha_CC = db.Nha_CC.Find(id);
            if (nha_CC == null)
            {
                return HttpNotFound();
            }
            return View(nha_CC);
        }

        // POST: NhaCCs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNCC,TenNCC,DiaChi,DienThoai,Email")] Nha_CC nha_CC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nha_CC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nha_CC);
        }

        // GET: NhaCCs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Nha_CC nha_CC = db.Nha_CC.Find(id);
            if (nha_CC == null)
            {
                return HttpNotFound();
            }
            return View(nha_CC);
        }

        // POST: NhaCCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Nha_CC nha_CC = db.Nha_CC.Find(id);
            db.Nha_CC.Remove(nha_CC);
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
