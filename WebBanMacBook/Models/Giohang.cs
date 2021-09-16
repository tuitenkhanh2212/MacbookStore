using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanMacBook.Models
{
    public class Giohang
    {
        // tao doi tuong data chua du lieu tu model mydata da tao
        MyDataDataContext data = new MyDataDataContext();
        public int iMaProduct { get; set; }
        public string sTenProduct { get; set; }
        public string SMota { get; set; }
        public string sAnhbia { get; set; }
        public double dDongia { get; set; }
        public int iSoluong { get; set; }
        public double dThanhtien
        {
            get { return iSoluong * dDongia; }
        }
        //khoi tao gio hang theo masach duoc truyen vao voi soluong mac dinh la 1
        public Giohang(int MaProduct)
        {
            iMaProduct = MaProduct;
            Product product = data.Products.Single(n => n.ProductID == iMaProduct);
            sTenProduct = product.ProductName;
            SMota = product.Description;
            sAnhbia = product.ImageSourceMain;
            dDongia = double.Parse(product.Price.ToString());
            iSoluong = 1;
        }
    }
}