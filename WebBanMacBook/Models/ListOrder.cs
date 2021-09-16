using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebBanMacBook.Models
{
    public class ListOrder
    {
        MyDataDataContext data = new MyDataDataContext();
        public int OrderID { get; set; }
        [Display(Name = "Tình Trạng Thanh Toán")]
        [Required(ErrorMessage = " Nhập đi bạn")]
        [RegularExpression(@"^[0-1]+$", ErrorMessage = "Chưa thanh toán nhập 0 đã thanh toán nhập 1")]
        public bool Paid { get; set; }
        [Display(Name = "Tình Trạng Giao Hàng")]
        [Required(ErrorMessage = " Nhập đi bạn")]
        [RegularExpression(@"^[0-1]+$", ErrorMessage = "Chưa Giao hàng nhập 0 đã giao hàng nhập 1")]
        public bool DeliveryStatus { get; set; }
        [Display(Name = "Ngày đặt hàng")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ngày giao hàng")]
        [Required(ErrorMessage = " Nhập đi bạn")]
        public DateTime DelieveryDate { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        [Display(Name = "Số lượng")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Số Only Please")]
        public int Amount { get; set; }
        [Display(Name = "Giá")]
        public decimal Price { get; set; }
        [Display(Name = "STT")]
        public int ID { get; set; }
        
        public ListOrder()
        {

        }
    }
}