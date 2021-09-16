using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanMacBook.Models;

namespace WebBanMacBook.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomeMenu(string productid)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getProductTop(productid);
            return View(obj);
        }

        public ActionResult ListProductMPOldForm(string tang,string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMPOld(tang,giam);
            return View(obj);
        }

        public ActionResult ListProductMP2020OldForm(string tang,string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMP2020Old(tang,giam);
            return View(obj);
        }
        public ActionResult ListProductMP2019OldForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMP2019Old(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMP2018OldForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMP2018Old(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMP2017OldForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMP2017Old(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMP2016OldForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMP2016Old(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMP2015OldForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMP2015Old(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMAOldForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMAOld(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMA2020OldForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMA2020Old(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMA2019OldForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMA2019Old(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMA2018OldForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMA2018Old(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMA2017OldForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMA2017Old(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMA2016OldForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMA2016Old(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMA2015OldForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMA2015Old(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMPNewForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMPNew(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMP2020NewForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMP2020New(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMP2019NewForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMP2019New(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMANewForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMANew(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMA2020NewForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMA2020New(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductMA2019NewForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductMA2019New(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductChuotPhimForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductChuotPhim(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductCapForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductCap(tang, giam);
            return View(obj);
        }
        public ActionResult ListProductTuiForm(string tang, string giam)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getproductTui(tang, giam);
            return View(obj);
        }
    }
}