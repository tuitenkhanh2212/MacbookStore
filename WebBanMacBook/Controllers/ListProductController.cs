using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanMacBook.Models;

namespace WebBanMacBook.Controllers
{
    public class ListProductController : Controller
    {
        // GET: ListProduct
        public ActionResult ListProductForm()
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getProduct(string.Empty);
            return View(obj);
        }

        public ActionResult DetailsForm(string Productid)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getProduct(Productid);
            return View(obj[0]);
        }
        public ActionResult DetailsFormPhuKien(string Productid)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getProductPhuKien(Productid);
            return View(obj[0]);
        }

    }
}