using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanMacBook.Models;

namespace WebBanMacBook.Controllers
{
    public class GiohangController : Controller
    {
        //tao doi tuong data chua du lieu tu model mydata da tao
        MyDataDataContext data = new MyDataDataContext();
        public List<Giohang> Laygiohang()
        {
            List<Giohang> listGiohang = Session["Giohang"] as List<Giohang>;
            if (listGiohang == null)
            {
                //Neu gio hang chua ton tai thi khoi tao listgiohang
                listGiohang = new List<Giohang>();
                Session["Giohang"] = listGiohang;
            }
            return listGiohang;
        }
        //Them hang vao gio
        public ActionResult ThemGiohang(int iMaProduct, string strURL)
        {
            //lay ra Session gio hang
            List<Giohang> listGiohang = Laygiohang();
            //kiem tra sach nay ton tai trong session ["giohang"] chua
            Giohang sanpham = listGiohang.Find(n => n.iMaProduct == iMaProduct);
            if (sanpham == null)
            {
                sanpham = new Giohang(iMaProduct);
                listGiohang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.iSoluong++;
                return Redirect(strURL);
            }
        }
        //tong so luong
        private int TongSoLuong()
        {
            int iTongSoLuong = 0;
            List<Giohang> listGiohang = Session["Giohang"] as List<Giohang>;
            if (listGiohang != null)
            {
                iTongSoLuong = listGiohang.Sum(n => n.iSoluong);
            }
            return iTongSoLuong;
        }
        //tinh tong tien
        private double TongTien()
        {
            double iTongTien = 0;
            List<Giohang> listGiohang = Session["Giohang"] as List<Giohang>;
            if (listGiohang != null)
            {
                iTongTien = listGiohang.Sum(n => n.dThanhtien);
            }
            return iTongTien;
        }
        //xay dung trang gio hang
        public ActionResult GioHang()
        {
            List<Giohang> listGiohang = Laygiohang();
            if (listGiohang.Count == 0)
            {
                return RedirectToAction("Giohangtrong", "Giohang");
            }
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            return View(listGiohang);
        }
        //tao partial view de hien thi thong tin gio hang
        public ActionResult GiohangPartial()
        {
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            return PartialView();
        }
        //Xoa Giohang
        public ActionResult Xoagiohang(int iMaSP)
        {
            //lay gio hang tu session
            List<Giohang> listGiohang = Laygiohang();
            //kiem tra sach da co trong session["giohang"]
            Giohang sanpham = listGiohang.SingleOrDefault(n => n.iMaProduct == iMaSP);
            //Neu ton tai thi cho sua soluong
            if (sanpham != null)
            {
                listGiohang.RemoveAll(n => n.iMaProduct == iMaSP);
                return RedirectToAction("GioHang");
            }
            if (listGiohang.Count == 0)
            {
                return RedirectToAction("HomeMenu", "Home");
            }
            return RedirectToAction("GioHang");
        }
        //Capnhat gio hang
        public ActionResult CapnhatGiohang(int iMaSP, FormCollection f)
        {
            //lay gio hang tu session
            List<Giohang> listGiohang = Laygiohang();
            //kiem tra sach da co trong session["giohang"]
            Giohang sanpham = listGiohang.SingleOrDefault(n => n.iMaProduct == iMaSP);
            //Neu ton tai thi cho sua soluong
            if (sanpham != null)
            {
                sanpham.iSoluong = int.Parse(f["txtSoluong"].ToString());
            }
            return RedirectToAction("Giohang");
        }
        //Delete all
        public ActionResult XoatatcaGiohang()
        {
            //Lay gio hang tu Session
            List<Giohang> listGiohang = Laygiohang();
            listGiohang.Clear();
            return RedirectToAction("Giohangtrong", "Giohang");
        } //
        [HttpGet]
        public ActionResult Dathang()
        {
            if (Session["Taikhoan"] == null || Session["Taikhoan"].ToString() == "")
            {
                return RedirectToAction("LoginForm", "Customer");
            }
            if (Session["Giohang"] == null)
            {
                return RedirectToAction("Giohangtrong", "Giohang");
            }
            //Lay gio hang tu seasson
            List<Giohang> listGiohang = Laygiohang();
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            return View(listGiohang);
        }
        public ActionResult Dathang(FormCollection collection)
        {
            Order or = new Order();
            ListAccount kh = (ListAccount)Session["info"];
            or.CustomerID = kh.CustomerID;
            List<Giohang> gh = Laygiohang();
            or.OrderDate = DateTime.Now;
            var ngaygiao = String.Format("{0:MM/dd/yyyy}", collection["Ngaygiao"]);
            or.DelieveryDate = DateTime.Parse(ngaygiao);
            or.DeliveryStatus = false;
            or.Paid = false;
            data.Orders.InsertOnSubmit(or);
            data.SubmitChanges();
            //them chi tiet don hang
            foreach (var item in gh)
            {
                OrderDetail od = new OrderDetail();
                od.OrderID = or.OrderID;
                od.ProductID = item.iMaProduct;
                od.Amount = item.iSoluong;
                od.Price = (decimal)item.dDongia;
                data.OrderDetails.InsertOnSubmit(od);
            }
            data.SubmitChanges();
            Session["Giohang"] = null;
            return RedirectToAction("Xacnhandonhang", "Giohang");

        }
        //
        public ActionResult Xacnhandonhang()
        {
            return View();
        }

        public ActionResult Giohangtrong()
        {
            return View();
        }
    }
}