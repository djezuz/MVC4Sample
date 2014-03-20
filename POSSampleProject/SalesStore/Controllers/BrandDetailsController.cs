using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SalesStore.Entities;

namespace SalesStore.Controllers
{
    public class BrandDetailsController : Controller
    {
        private SalesDBContext db = new SalesDBContext();

        // GET: /BrandDetails/
        public async Task<ActionResult> Index()
        {
            return View(await db.ItemBrands.ToListAsync());
        }

        // GET: /BrandDetails/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemBrand itembrand = await db.ItemBrands.FindAsync(id);
            if (itembrand == null)
            {
                return HttpNotFound();
            }
            return View(itembrand);
        }

        // GET: /BrandDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /BrandDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include="itemBrandCode,brandName,arabicName,isActive")] ItemBrand itembrand)
        {
            if (ModelState.IsValid)
            {
                db.ItemBrands.Add(itembrand);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(itembrand);
        }

        // GET: /BrandDetails/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemBrand itembrand = await db.ItemBrands.FindAsync(id);
            if (itembrand == null)
            {
                return HttpNotFound();
            }
            return View(itembrand);
        }

        // POST: /BrandDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include="itemBrandCode,brandName,arabicName,isActive")] ItemBrand itembrand)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itembrand).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(itembrand);
        }

        // GET: /BrandDetails/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemBrand itembrand = await db.ItemBrands.FindAsync(id);
            if (itembrand == null)
            {
                return HttpNotFound();
            }
            return View(itembrand);
        }

        // POST: /BrandDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ItemBrand itembrand = await db.ItemBrands.FindAsync(id);
            db.ItemBrands.Remove(itembrand);
            await db.SaveChangesAsync();
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
