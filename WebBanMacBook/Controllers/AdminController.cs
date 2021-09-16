using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanMacBook.Models;
using ListProduct = WebBanMacBook.Models.ListProduct;

namespace WebBanMacBook.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AdminForm()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminForm(ListAccount model)
        {
            CustomerQuery qr = new CustomerQuery();
            if (qr.CheckAccountAdmin(model.Account, model.Password))
            {
                ListAccount kh = qr.getAdminID(model.Account);
                Session["info"] = kh;
                Session["Name"] = kh.FirstName;
                Session["taikhoan"] = kh.Account;
                return View("ManageForm");
            }
            else
            {
                ViewBag.LoginFail = "Tài khoản hoặc mật khẩu không đúng !";
                return View();
            }

        }
        public ActionResult ManageForm()
        {
            if (Session["Name"] == null)
            {
                return RedirectToAction("AdminForm", "Admin");
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult CpuForm(string id)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getCPU(id);
            return View(obj);
        }

        public ActionResult CreateCPUForm()
        {
            return View();
        }
        [HttpPost, ActionName("CreateCPUForm")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCPUForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.CreateCPU(model))
            {
                list = qr.getCPU(String.Empty);
                return View("CpuForm", list);
            }
            else
            {
                ViewBag.Thongbaotrung = " Mã CPU đã tồn tại !";
            }
            return View();
        }
        public ActionResult UpdateCPUForm(string cpuid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getCPU(cpuid);
            return View(obj[0]);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateCPUForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.UpdateCPU(model))
            {
                list = qr.getCPU(String.Empty);
                return View("CpuForm", list);
            }
            return View("CpuForm", list);
        }
        public ActionResult DeleteCPU(string cpuid)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.DeleteCPU(cpuid))
            {
                list = qr.getCPU(String.Empty);
                return View("CpuForm", list);
            }
            return View("CpuForm", list);
        }
        public ActionResult ColorForm(string id)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getColor(id);
            return View(obj);
        }
        public ActionResult CreateColorForm()
        {
            return View();
        }
        [HttpPost, ActionName("CreateColorForm")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateColorForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            if (qr.CreateColor(model))
            {
                return RedirectToAction("ColorForm", "Admin");
            }
            else
            {
                ViewBag.Thongbaotrung = " Mã Color đã tồn tại !";
            }
            return View();
        }
        public ActionResult UpdateColorForm(string colorid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getColor(colorid);
            return View(obj[0]);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateColorForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.UpdateColor(model))
            {
                list = qr.getColor(String.Empty);
                return View("ColorForm", list);
            }
            return View("ColorForm", list);
        }
        public ActionResult DeleteColor(string colorid)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.DeleteColor(colorid))
            {
                list = qr.getColor(String.Empty);
                return View("ColorForm", list);
            }
            return View("ColorForm", list);
        }
        public ActionResult DisplayForm(string displayid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getDisplay(displayid);
            return View(obj);
        }
        public ActionResult CreateDisplayForm()
        {
            return View();
        }
        [HttpPost, ActionName("CreateDisplayForm")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDisplayForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            if (qr.CreateDisplay(model))
            {
                return RedirectToAction("DisplayForm", "Admin");
            }
            else
            {
                ViewBag.Thongbaotrung = " Mã Display đã tồn tại !";
            }
            return View();
        }
        public ActionResult UpdateDisplayForm(string displayid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getDisplay(displayid);
            return View(obj[0]);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateDisplayForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.UpdateDisplay(model))
            {
                list = qr.getDisplay(String.Empty);
                return View("DisplayForm", list);
            }
            return View("DisplayForm", list);
        }
        public ActionResult DeleteDisplay(string displayid)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.DeleteDisplay(displayid))
            {
                list = qr.getDisplay(String.Empty);
                return View("DisplayForm", list);
            }
            return View("DisplayForm", list);
        }
        public ActionResult DisplayCardForm(string displaycardid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getDisplayCard(displaycardid);
            return View(obj);
        }
        public ActionResult CreateDisplayCardForm()
        {
            return View();
        }
        [HttpPost, ActionName("CreateDisplayCardForm")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDisplayCardForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            if (qr.CreateDisplayCard(model))
            {
                return RedirectToAction("DisplayCardForm", "Admin");
            }
            else
            {
                ViewBag.Thongbaotrung = " Mã DisplayCard đã tồn tại !";
            }
            return View();
        }
        public ActionResult UpdateDisplayCardForm(string displaycardid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getDisplayCard(displaycardid);
            return View(obj[0]);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateDisplayCardForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.UpdateDisplayCard(model))
            {
                list = qr.getDisplayCard(String.Empty);
                return View("DisplayCardForm", list);
            }
            return View("DisplayCardForm", list);
        }
        public ActionResult DeleteDisplayCard(string displaycardid)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.DeleteDisplayCard(displaycardid))
            {
                list = qr.getDisplayCard(String.Empty);
                return View("DisplayCardForm", list);
            }
            return View("DisplayCardForm", list);
        }
        public ActionResult HardDriveForm(string harddriveid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getHardDrive(harddriveid);
            return View(obj);
        }
        public ActionResult CreateHardDriveForm()
        {
            return View();
        }
        [HttpPost, ActionName("CreateHardDriveForm")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateHardDriveForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            if (qr.CreateHardDrive(model))
            {
                return RedirectToAction("HardDriveForm", "Admin");
            }
            else
            {
                ViewBag.Thongbaotrung = " Mã HardDrive đã tồn tại !";
            }
            return View();
        }
        public ActionResult UpdateHardDriveForm(string harddriveid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getHardDrive(harddriveid);
            return View(obj[0]);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateHardDriveForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.UpdateHardDrive(model))
            {
                list = qr.getHardDrive(String.Empty);
                return View("HardDriveForm", list);
            }
            return View("HardDriveForm", list);
        }
        public ActionResult DeleteHardDrive(string harddriveid)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.DeleteHardDrive(harddriveid))
            {
                list = qr.getHardDrive(String.Empty);
                return View("HardDriveForm", list);
            }
            return View("HardDriveForm", list);
        }
        public ActionResult YearForm(string yearid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getYear(yearid);
            return View(obj);
        }
        public ActionResult CreateYearForm()
        {
            return View();
        }
        [HttpPost, ActionName("CreateYearForm")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateYearForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            if (qr.CreateYear(model))
            {
                return RedirectToAction("YearForm", "Admin");
            }
            else
            {
                ViewBag.Thongbaotrung = " Mã Year đã tồn tại !";
            }
            return View();
        }
        public ActionResult UpdateYearForm(string yearid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getYear(yearid);
            return View(obj[0]);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateYearForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.UpdateYear(model))
            {
                list = qr.getYear(String.Empty);
                return View("YearForm", list);
            }
            return View("YearForm", list);
        }
        public ActionResult DeleteYear(string yearid)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.DeleteYear(yearid))
            {
                list = qr.getYear(String.Empty);
                return View("YearForm", list);
            }
            return View("YearForm", list);
        }
        public ActionResult GroupForm(string groupid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getGroup(groupid);
            return View(obj);
        }
        public ActionResult CreateGroupForm()
        {
            return View();
        }
        [HttpPost, ActionName("CreateGroupForm")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateGroupForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            if (qr.CreateGroup(model))
            {
                return RedirectToAction("GroupForm", "Admin");
            }
            else
            {
                ViewBag.Thongbaotrung = " Mã Group đã tồn tại !";
            }
            return View();
        }
        public ActionResult UpdateGroupForm(string groupid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getGroup(groupid);
            return View(obj[0]);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateGroupForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.UpdateGroup(model))
            {
                list = qr.getGroup(String.Empty);
                return View("GroupForm", list);
            }
            return View("GroupForm", list);
        }
        public ActionResult DeleteGroup(string groupid)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.DeleteGroup(groupid))
            {
                list = qr.getGroup(String.Empty);
                return View("GroupForm", list);
            }
            return View("GroupForm", list);
        }
        public ActionResult RamForm(string ramid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getRam(ramid);
            return View(obj);
        }
        public ActionResult CreateRamForm()
        {
            return View();
        }
        [HttpPost, ActionName("CreateRamForm")]
        [ValidateAntiForgeryToken]
        public ActionResult CreateRamForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            if (qr.CreateRam(model))
            {
                return RedirectToAction("RamForm", "Admin");
            }
            else
            {
                ViewBag.Thongbaotrung = " Mã Ram đã tồn tại !";
            }
            return View();
        }
        public ActionResult UpdateRamForm(string ramid)
        {
            ThuocTinhQuery str = new ThuocTinhQuery();
            List<ListThuocTinh> obj = str.getRam(ramid);
            return View(obj[0]);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateRamForm(ListThuocTinh model)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.UpdateRam(model))
            {
                list = qr.getRam(String.Empty);
                return View("RamForm", list);
            }
            return View("RamForm", list);
        }
        public ActionResult DeleteRam(string ramid)
        {
            ThuocTinhQuery qr = new ThuocTinhQuery();
            List<ListThuocTinh> list = new List<ListThuocTinh>();
            if (qr.DeleteRam(ramid))
            {
                list = qr.getRam(String.Empty);
                return View("RamForm", list);
            }
            return View("RamForm", list);
        }

        public ActionResult ProductForm(string id)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getProduct(id);
            return View(obj);
        }
        public ActionResult CreateProductForm()
        {
            ListProduct temp = new ListProduct();
            ThuocTinhQuery qr = new ThuocTinhQuery();
            temp.listcpu = qr.getListCPU();
            temp.listcolor = qr.getListColor();
            temp.listdisplay = qr.getListDisplay();
            temp.listdisplaycard = qr.getListDisplayCard();
            temp.listgroup = qr.getListGroupMac();
            temp.listharddrive = qr.getListHardDrive();
            temp.listram = qr.getListRam();
            temp.listyear = qr.getListYear();

            return View(temp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProductForm(ListProduct model, HttpPostedFileBase file, HttpPostedFileBase file1, HttpPostedFileBase file2, HttpPostedFileBase file3)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName);
                model.ImageSource = "/Content/Image/" + fileName;
                file.SaveAs((path));
            }
            if (file1.ContentLength > 0)
            {
                var fileName1 = Path.GetFileName(file1.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName1);
                model.ImageSource1 = "/Content/Image/" + fileName1;
                file1.SaveAs((path));
            }
            if (file2.ContentLength > 0)
            {
                var fileName2 = Path.GetFileName(file2.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName2);
                model.ImageSource2 = "/Content/Image/" + fileName2;
                file2.SaveAs((path));
            }
            if (file3.ContentLength > 0)
            {
                var fileName3 = Path.GetFileName(file3.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName3);
                model.ImageSource3 = "/Content/Image/" + fileName3;
                file3.SaveAs((path));
            }
            ProductQuery qr = new ProductQuery();
            List<ListProduct> list = new List<ListProduct>();
            if (qr.CreateProduct(model))
            {
                list = qr.getProduct(String.Empty);
                return View("ProductForm", list);
            }
            else
            {
                ViewBag.Thongbaotrung = "";
            }
            return View("ProductForm", list);
        }
        public ActionResult UpdateProductForm(string productid)
        {
            ListProduct temp = new ListProduct();
            ThuocTinhQuery qr = new ThuocTinhQuery();
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getProduct(productid);
            ViewBag.cpu = obj.FirstOrDefault().CpuId;
            temp = obj.FirstOrDefault();
            temp.listcpu = qr.getListCPU();
            List<CpuList> cpu = temp.listcpu.ToList();
            for (int i = 0; i < cpu.Count(); i++)
            {
                if (cpu[i].CpuName == temp.CpuId)
                {
                    ViewBag.cpuId = cpu[i].CpuId;
                    break;
                }
            }
            temp.listcolor = qr.getListColor();
            List<ColorList> color = temp.listcolor.ToList();
            for (int i = 0; i < color.Count(); i++)
            {
                if (color[i].ColorName == temp.ColorId)
                {
                    ViewBag.colorId = color[i].ColorId;
                    break;
                }
            }
            temp.listdisplay = qr.getListDisplay();
            List<DisplayList> display = temp.listdisplay.ToList();
            for (int i = 0; i < display.Count(); i++)
            {
                if (display[i].DisplayName == temp.DisplayId)
                {
                    ViewBag.displayId = display[i].DisplayId;
                    break;
                }
            }
            temp.listdisplaycard = qr.getListDisplayCard();
            List<DisplayCardList> displaycard = temp.listdisplaycard.ToList();
            for (int i = 0; i < displaycard.Count(); i++)
            {
                if (displaycard[i].DisplayCardName == temp.DisplayCardId)
                {
                    ViewBag.displaycardId = displaycard[i].DisplayCardId;
                    break;
                }
            }
            temp.listgroup = qr.getListGroupMac();
            List<GroupList> group = temp.listgroup.ToList();
            for (int i = 0; i < group.Count(); i++)
            {
                if (group[i].GroupName == temp.GroupId)
                {
                    ViewBag.groupId = group[i].GroupId;
                    break;
                }
            }
            temp.listharddrive = qr.getListHardDrive();
            List<HardDriveList> harddrive = temp.listharddrive.ToList();
            for (int i = 0; i < harddrive.Count(); i++)
            {
                if (harddrive[i].HardDriveName == temp.HardDriveId)
                {
                    ViewBag.harddriveId = harddrive[i].HardDriveId;
                    break;
                }
            }
            temp.listram = qr.getListRam();
            List<RamList> ram = temp.listram.ToList();
            for (int i = 0; i < ram.Count(); i++)
            {
                if (ram[i].RamName == temp.RamId)
                {
                    ViewBag.ramId = ram[i].RamId;
                    break;
                }
            }
            temp.listyear = qr.getListYear();
            List<YearList> year = temp.listyear.ToList();
            for (int i = 0; i < year.Count(); i++)
            {
                if (year[i].YearName == temp.YearId)
                {
                    ViewBag.yearId = year[i].YearId;
                    break;
                }
            }
            return View(temp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateProductForm(ListProduct model, HttpPostedFileBase file, HttpPostedFileBase file1, HttpPostedFileBase file2, HttpPostedFileBase file3)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName);
                model.ImageSource = "/Content/Image/" + fileName;
                file.SaveAs((path));
            }
            if (file1.ContentLength > 0)
            {
                var fileName1 = Path.GetFileName(file1.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName1);
                model.ImageSource1 = "/Content/Image/" + fileName1;
                file1.SaveAs((path));
            }
            if (file2.ContentLength > 0)
            {
                var fileName2 = Path.GetFileName(file2.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName2);
                model.ImageSource2 = "/Content/Image/" + fileName2;
                file2.SaveAs((path));
            }
            if (file3.ContentLength > 0)
            {
                var fileName3 = Path.GetFileName(file3.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName3);
                model.ImageSource3 = "/Content/Image/" + fileName3;
                file3.SaveAs((path));
            }
            ProductQuery qr = new ProductQuery();
            List<ListProduct> list = new List<ListProduct>();
            if (qr.UpdateProduct(model))
            {
                list = qr.getProduct(String.Empty);
                return View("ProductForm", list);
            }
            else
            {
                ViewBag.Thongbaotrung = "";
            }
            return View("ProductForm", list);
        }
        public ActionResult DeleteProduct(string productid)
        {
            ProductQuery qr = new ProductQuery();
            List<ListProduct> list = new List<ListProduct>();
            if (qr.DeleteProduct(productid))
            {
                list = qr.getProduct(String.Empty);
                return View("ProductForm", list);
            }
            return View("ProductForm", list);
        }
        public ActionResult PhukienForm(string id)
        {
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getProductPhuKien(id);
            return View(obj);
        }
        public ActionResult CreatePhuKienForm()
        {
            ListProduct temp = new ListProduct();
            ThuocTinhQuery qr = new ThuocTinhQuery();
            temp.listcolor = qr.getListColor();
            temp.listgroup = qr.getListGroupPK();
            temp.listyear = qr.getListYear();

            return View(temp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePhuKienForm(ListProduct model, HttpPostedFileBase file, HttpPostedFileBase file1, HttpPostedFileBase file2, HttpPostedFileBase file3)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName);
                model.ImageSource = "/Content/Image/" + fileName;
                file.SaveAs((path));
            }
            if (file1.ContentLength > 0)
            {
                var fileName1 = Path.GetFileName(file1.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName1);
                model.ImageSource1 = "/Content/Image/" + fileName1;
                file1.SaveAs((path));
            }
            if (file2.ContentLength > 0)
            {
                var fileName2 = Path.GetFileName(file2.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName2);
                model.ImageSource2 = "/Content/Image/" + fileName2;
                file2.SaveAs((path));
            }
            if (file3.ContentLength > 0)
            {
                var fileName3 = Path.GetFileName(file3.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName3);
                model.ImageSource3 = "/Content/Image/" + fileName3;
                file3.SaveAs((path));
            }
            ProductQuery qr = new ProductQuery();
            List<ListProduct> list = new List<ListProduct>();
            if (qr.CreatePhukien(model))
            {
                list = qr.getProductPhuKien(String.Empty);
                return View("PhukienForm", list);
            }
            else
            {
                ViewBag.Thongbaotrung = "";
            }
            return View("PhukienForm", list);
        }
        public ActionResult UpdatePhuKienForm(string productid)
        {
            ListProduct temp = new ListProduct();
            ThuocTinhQuery qr = new ThuocTinhQuery();
            ProductQuery str = new ProductQuery();
            List<ListProduct> obj = str.getProductPhuKien(productid);
            ViewBag.cpu = obj.FirstOrDefault().CpuId;
            temp = obj.FirstOrDefault();
            temp.listcolor = qr.getListColor();
            List<ColorList> color = temp.listcolor.ToList();
            for (int i = 0; i < color.Count(); i++)
            {
                if (color[i].ColorName == temp.ColorId)
                {
                    ViewBag.colorId = color[i].ColorId;
                    break;
                }
            }
            temp.listgroup = qr.getListGroupPK();
            List<GroupList> group = temp.listgroup.ToList();
            for (int i = 0; i < group.Count(); i++)
            {
                if (group[i].GroupName == temp.GroupId)
                {
                    ViewBag.groupId = group[i].GroupId;
                    break;
                }
            }
            temp.listyear = qr.getListYear();
            List<YearList> year = temp.listyear.ToList();
            for (int i = 0; i < year.Count(); i++)
            {
                if (year[i].YearName == temp.YearId)
                {
                    ViewBag.yearId = year[i].YearId;
                    break;
                }
            }
            return View(temp);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UpdatePhukienForm(ListProduct model, HttpPostedFileBase file, HttpPostedFileBase file1, HttpPostedFileBase file2, HttpPostedFileBase file3)
        {
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName);
                model.ImageSource = "/Content/Image/" + fileName;
                file.SaveAs((path));
            }
            if (file1.ContentLength > 0)
            {
                var fileName1 = Path.GetFileName(file1.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName1);
                model.ImageSource1 = "/Content/Image/" + fileName1;
                file1.SaveAs((path));
            }
            if (file2.ContentLength > 0)
            {
                var fileName2 = Path.GetFileName(file2.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName2);
                model.ImageSource2 = "/Content/Image/" + fileName2;
                file2.SaveAs((path));
            }
            if (file3.ContentLength > 0)
            {
                var fileName3 = Path.GetFileName(file3.FileName);
                var path = Path.Combine(Server.MapPath("~/Content/Image"), fileName3);
                model.ImageSource3 = "/Content/Image/" + fileName3;
                file3.SaveAs((path));
            }
            ProductQuery qr = new ProductQuery();
            List<ListProduct> list = new List<ListProduct>();
            if (qr.UpdatePhukien(model))
            {
                list = qr.getProductPhuKien(String.Empty);
                return View("PhukienForm", list);
            }
            else
            {
                ViewBag.Thongbaotrung = "";
            }
            return View("PhukienForm", list);
        }
        public ActionResult DeletePhukien(string productid)
        {
            ProductQuery qr = new ProductQuery();
            List<ListProduct> list = new List<ListProduct>();
            if (qr.DeleteProduct(productid))
            {
                list = qr.getProductPhuKien(String.Empty);
                return View("PhukienForm", list);
            }
            return View("PhukienForm", list);
        }

        public ActionResult AdminCustomerForm(string id)
        {
            CustomerQuery qr = new CustomerQuery();
            List<ListAccount> obj = qr.getCustomerList(id);
            return View(obj);
        }
        public ActionResult UpdateCustomerForm(string id)
        {
            CustomerQuery qr = new CustomerQuery();
            List<ListAccount> obj = qr.getCustomerList(id);
            return View(obj[0]);
        }
        [HttpPost,ActionName("UpdateCustomerForm")]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateCustomerForm(ListAccount model)
        {
            CustomerQuery qr = new CustomerQuery();
            if (qr.UpdateAccount(model))
            {
                return RedirectToAction("AdminCustomerForm", "Admin");
            }
            else
            {
                ViewBag.Thongbaotrung = "";
            }
            return View();
        }
        public ActionResult DeleteCustomer(string id)
        {
            CustomerQuery qr = new CustomerQuery();
            List<ListAccount> list = new List<ListAccount>();
            if (qr.DeleteAccount(id))
            {
                list = qr.getCustomerList(String.Empty);
                return View("AdminCustomerForm", list);
            }
            return View("AdminCustomerForm", list);
        }
        public ActionResult OrderForm(string id)
        {
            OrderQuery qr = new OrderQuery();
            List<ListOrder> obj = qr.getOrderList(id);
            return View(obj);
        }
        public ActionResult UpdateOrderForm(string id)
        {
            OrderQuery qr = new OrderQuery();
            List<ListOrder> obj = qr.getOrderList(id);
            return View(obj[0]);
        }
        [HttpPost, ActionName("UpdateOrderForm")]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateOrderForm(ListOrder model)
        {
            OrderQuery qr = new OrderQuery();
            if (qr.UpdateOrder(model))
            {
                return RedirectToAction("OrderForm", "Admin");
            }
            else
            {
                ViewBag.Thongbaotrung = "";
            }
            return View();
        }
        public ActionResult DeleteOrder(string id)
        {
            OrderQuery qr = new OrderQuery();
            List<ListOrder> list = new List<ListOrder>();
            if (qr.DeleteOrder(id))
            {
                list = qr.getOrderList(String.Empty);
                return View("OrderForm", list);
            }

            return View("OrderForm", list);
        }
        public ActionResult OrderDetailsForm(string id)
        {
            OrderQuery qr = new OrderQuery();
            List<ListOrder> obj = qr.getOrderDetailsList(id);
            return View(obj);
        }
        public ActionResult UpdateOrderDetailsForm(string id)
        {
            OrderQuery qr = new OrderQuery();
            List<ListOrder> obj = qr.getOrderDetailsList(id);
            return View(obj[0]);
        }
        [HttpPost, ActionName("UpdateOrderDetailsForm")]
        [ValidateAntiForgeryToken]
        public ActionResult UpdateOrderDetailsForm(ListOrder model)
        {
            OrderQuery qr = new OrderQuery();
            if (qr.UpdateOrderDetails(model))
            {
                return RedirectToAction("OrderDetailsForm", "Admin");
            }
            else
            {
                ViewBag.Thongbaotrung = "";
            }
            return View();
        }
        public ActionResult DeleteOrderDetails(string id)
        {
            OrderQuery qr = new OrderQuery();
            List<ListOrder> list = new List<ListOrder>();
            if (qr.DeleteOrderDetails(id))
            {
                list = qr.getOrderDetailsList(String.Empty);
                return View("OrderDetailsForm", list);
            }

            return View("OrderDetailsForm", list);
        }
    }
}