using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClothesStore.DatabaseContext;
using ClothesStore.Models;

namespace ClothesStore.Controllers
{
    public class ItemsController : Controller
    {
        private ShopDbContext db = new ShopDbContext();

        
        // GET: Items
        public ActionResult Index()
        {
            List<Item> items = db.Items.OrderBy(x => x.Name).ToList();
            return View(items);
        }

        // GET: Items/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        public ActionResult AddToCart(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Item items = db.Items.Find(id);
			if (items == null)
			{
				return HttpNotFound();
			}
			var ShoppingCart = db.ShoppingCarts.OrderByDescending(x => x.DateCreated).FirstOrDefault();
			if (ShoppingCart == null)
			{
				ShoppingCart = db.ShoppingCarts.Add(new ShoppingCart());
			}
			ShoppingCart.AddToCart(items);
			db.SaveChanges();
			//return RedirectToAction("Index", "ShoppingCarts");
			return RedirectToAction("Details", "ShoppingCarts", new { id = ShoppingCart.Id });
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
