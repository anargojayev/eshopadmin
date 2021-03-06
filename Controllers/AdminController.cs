using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eshopadmin.Models;
using System.IO;

namespace eshopadmin.Controllers
{
    public class AdminController : Controller
    {
        DataClassDataContext DataBase = new DataClassDataContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Category()
        {
            List<Category> kateqoriya = new List<Category>();
            kateqoriya = DataBase.Categories.ToList();
            return View(kateqoriya);
        }
        [HttpPost]
        public ActionResult Category(Category kateqoriya)
        {
            if(kateqoriya.CategoryID == 0)
            {
                DataBase.Categories.InsertOnSubmit(kateqoriya);
            }
            else
            {
                Category selectedCategory = DataBase.Categories.SingleOrDefault(x => x.CategoryID == kateqoriya.CategoryID);
                selectedCategory.CategoryName = kateqoriya.CategoryName;
            }
            DataBase.SubmitChanges();
            return RedirectToAction("Category");
        }
        public ActionResult DeleteCategoryRow(int id)
        {
            DataBase.Categories.DeleteOnSubmit(DataBase.Categories.SingleOrDefault(x => x.CategoryID == id));
            DataBase.SubmitChanges();
            return RedirectToAction("Category");
        }
        [HttpGet]
        public ActionResult Product()
        {
            List<ProductView> mehsul = new List<ProductView>();
            mehsul = DataBase.ProductViews.ToList();
            List<Category> kateqoriya = new List<Category>();
            kateqoriya = DataBase.Categories.ToList();
            ViewBag.Category = kateqoriya.ToList();
            return View(mehsul);
        }
        [HttpPost]
        public ActionResult Product(Product mehsul)
        {
            if (mehsul.ProductID == 0)
            {
                DataBase.Products.InsertOnSubmit(mehsul);
            }
            else
            {
                ProductView selectedProduct = DataBase.ProductViews.SingleOrDefault(x => x.ProductID == mehsul.ProductID);
                selectedProduct.ProductName = mehsul.ProductName;
                selectedProduct.ProductPrice = mehsul.ProductPrice;
                selectedProduct.ProductDiscount = mehsul.ProductDiscount;
                selectedProduct.ProductInfo = mehsul.ProductInfo;
            }
            DataBase.SubmitChanges();
            return RedirectToAction("Product");
        }
        public ActionResult DeleteProductRow(int id)
        {
            DataBase.Products.DeleteOnSubmit(DataBase.Products.SingleOrDefault(x => x.ProductID == id));
            DataBase.SubmitChanges();
            return RedirectToAction("Product");
        }
        public ActionResult About()
        {
            List<About> melumat = new List<About>();
            melumat = DataBase.Abouts.ToList();
            return View(melumat);
        }
        [HttpPost]
        public ActionResult About(About melumat)
        {
            if (melumat.AboutID == 0)
            {
                DataBase.Abouts.InsertOnSubmit(melumat);
            }
            else
            {
                About selectedInfo = DataBase.Abouts.SingleOrDefault(x => x.AboutID == melumat.AboutID);
                selectedInfo.AboutPhoneNumber = melumat.AboutPhoneNumber;
                selectedInfo.AboutEmail = melumat.AboutEmail;
                selectedInfo.AboutFacebook = melumat.AboutFacebook;
                selectedInfo.AboutInstagram = melumat.AboutInstagram;
                selectedInfo.AboutWhatsapp = melumat.AboutWhatsapp;
                selectedInfo.AboutInfo = melumat.AboutInfo;
            }
            DataBase.SubmitChanges();
            return RedirectToAction("About");
        }
        public ActionResult DeleteAboutRow(int id)
        {
            DataBase.Abouts.DeleteOnSubmit(DataBase.Abouts.SingleOrDefault(x => x.AboutID == id));
            DataBase.SubmitChanges();
            return RedirectToAction("About");
        }
    }
}