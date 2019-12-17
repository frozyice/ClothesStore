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
            List<Article> items = db.Articles.OrderBy(x => x.Name).ToList();
            return View(items);
        }

        // GET: Items/Details/5
        //OK
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //OK
        public ActionResult AddToCart(Guid? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Article article = db.Articles.Find(id);
			if (article == null)
			{
				return HttpNotFound();
			}
			ShoppingCart ShoppingCart = db.ShoppingCarts.OrderByDescending(x => x.DateCreated).FirstOrDefault();
			if (ShoppingCart == null || ShoppingCart.IsPaid==true)
			{
				ShoppingCart = db.ShoppingCarts.Add(new ShoppingCart());
			}
            ShoppingCart.AddToCart(article);
            //ShoppingCart.AddToCart(items);
			db.SaveChanges();
			//return RedirectToAction("Index", "ShoppingCarts");
			return RedirectToAction("Details", "ShoppingCarts", new { id = ShoppingCart.ShoppingcartId });
		}

        public ActionResult RemoveFromCart(Guid? id)
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
            ShoppingCart ShoppingCart = db.ShoppingCarts.OrderByDescending(x => x.DateCreated).FirstOrDefault();
            if (ShoppingCart != null && ShoppingCart.IsPaid == false)
            {
                ShoppingCart.RemoveFromCart(item);
                db.SaveChanges();
            }
            return RedirectToAction("Details", "ShoppingCarts", new { id = ShoppingCart.ShoppingcartId });

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
