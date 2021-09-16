using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanMacBook.Models;

namespace WebBanMacBook.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult RegisterForm()
        {

            return View();
        }
        [HttpPost, ActionName("RegisterForm")]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterForm(ListAccount model)
        {
            CustomerQuery qr = new CustomerQuery();
            if (qr.CreateAccount(model))
            {
                return RedirectToAction("LoginForm", "Customer");
            }
            else
            {
                ViewBag.Thongbaotrung = " / Tên đăng nhập đã tồn tại !";
            }
            return View();
        }
        public ActionResult RegisterPartial()
        {
            return PartialView();
        }

        public ActionResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LoginForm(ListAccount model)
        {
            CustomerQuery qr = new CustomerQuery();
            if (qr.CheckAccount(model.Account, model.Password))
            {
                ListAccount kh = qr.getCustomerID(model.Account);
                Session["info"] = kh;
                Session["ho"] = kh.FirstName;
                Session["ten"] = kh.LastName;
                Session["taikhoan"] = kh.Account;
                return RedirectToAction("HomeMenu", "Home");
            }
            else
            {
                ViewBag.LoginFail = "Tài khoản hoặc mật khẩu không đúng !";
                return View();
            }

        }
        public ActionResult LoginPartial()
        {
            return PartialView();
        }
        public ActionResult Logout()
        {
            Session["info"] = null;
            Session["taikhoan"] = null;
            Session["ten"] = null;
            Session["message"] = null;
            Session["GioHang"] = null;
            return RedirectToAction("LoginForm");
        }

        public ActionResult AccountDetail(string account)
        {
            CustomerQuery qr = new CustomerQuery();
            ListAccount obj = qr.getCustomerID(account);
            return View(obj);
        }
        [HttpPost, ActionName("AccountDetail")]
        [ValidateAntiForgeryToken]
        public ActionResult AccountDetail(ListAccount model)
        {
            CustomerQuery qr = new CustomerQuery();
            if (qr.UpdateAccount(model))
            {
                return RedirectToAction("HomeMenu", "Home");
            }
            else
            {
                ViewBag.Thongbaotrung = "";
            }
            return View();
        }
        public ActionResult AccountDetailPartial()
        {
            return PartialView();
        }
    }
}