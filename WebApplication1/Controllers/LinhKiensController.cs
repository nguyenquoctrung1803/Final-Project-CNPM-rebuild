using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LinhKiensController : Controller
    {
        private PM_BanLinhKienPCEntities db = new PM_BanLinhKienPCEntities();

        // GET: LinhKiens
        public ActionResult Index()
        {
            return View(db.LinhKiens.ToList());
        }

        // GET: LinhKiens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LinhKien linhKien = db.LinhKiens.Find(id);
            if (linhKien == null)
            {
                return HttpNotFound();
            }
            return View(linhKien);
        }

        // GET: LinhKiens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LinhKiens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLK,MaLLK,MaNCC,TenLK,BaoHanh,XuatXu,TinhTrang,DonViTinh,DonGia,SoLuongTon,KhuyenMai,HinhAnh,TrangThai")] LinhKien linhKien)
        {
            if (ModelState.IsValid)
            {
                db.LinhKiens.Add(linhKien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(linhKien);
        }

        // GET: LinhKiens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LinhKien linhKien = db.LinhKiens.Find(id);
            if (linhKien == null)
            {
                return HttpNotFound();
            }
            return View(linhKien);
        }

        // POST: LinhKiens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLK,MaLLK,MaNCC,TenLK,BaoHanh,XuatXu,TinhTrang,DonViTinh,DonGia,SoLuongTon,KhuyenMai,HinhAnh,TrangThai")] LinhKien linhKien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(linhKien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(linhKien);
        }

        // GET: LinhKiens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LinhKien linhKien = db.LinhKiens.Find(id);
            if (linhKien == null)
            {
                return HttpNotFound();
            }
            return View(linhKien);
        }

        // POST: LinhKiens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LinhKien linhKien = db.LinhKiens.Find(id);
            db.LinhKiens.Remove(linhKien);
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
